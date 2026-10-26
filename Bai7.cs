using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            tvFolder.BeforeExpand += tvFolder_BeforeExpand;
            tvFolder.NodeMouseDoubleClick += tvFolder_NodeMouseDoubleClick;
            tvFolder.AfterSelect += tvFolder_AfterSelect;

            picFile.Visible = false;
            rtbFile.Visible = false;
            rtbFile.ReadOnly = true;

            TaiDanhSachODia();
        }

        private void TaiDanhSachODia()
        {
            tvFolder.Nodes.Clear();
            foreach (System.IO.DriveInfo drive in System.IO.DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    string tenHienThi = string.IsNullOrEmpty(drive.VolumeLabel)
                        ? $"Local Disk ({drive.Name})"
                        : $"{drive.VolumeLabel} ({drive.Name})";

                    TreeNode driveNode = new TreeNode(tenHienThi);
                    driveNode.Tag = drive.RootDirectory.FullName;
                    driveNode.Nodes.Add("...");
                    tvFolder.Nodes.Add(driveNode);
                }
            }
        }

        private void TaiThuMucVaFile(TreeNode parentNode)
        {
            if (parentNode.Nodes.Count == 1 && parentNode.Nodes[0].Text == "...")
            {
                parentNode.Nodes.Clear();
            }
            else if (parentNode.Nodes.Count > 0)
            {
                return;
            }

            string currentPath = parentNode.Tag.ToString();
            try
            {
                string[] directories = System.IO.Directory.GetDirectories(currentPath);
                foreach (string dir in directories)
                {
                    System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(dir);
                    if ((dirInfo.Attributes & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden)
                        continue;

                    TreeNode folderNode = new TreeNode(dirInfo.Name);
                    folderNode.Tag = dirInfo.FullName;
                    folderNode.Nodes.Add("...");
                    parentNode.Nodes.Add(folderNode);
                }

                string[] files = System.IO.Directory.GetFiles(currentPath);
                foreach (string file in files)
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                    if ((fileInfo.Attributes & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden)
                        continue;

                    TreeNode fileNode = new TreeNode(fileInfo.Name);
                    fileNode.Tag = fileInfo.FullName;
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Bỏ qua lỗi các thư mục hệ thống Windows không cho phép truy cập
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi truy cập: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tvFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TaiThuMucVaFile(e.Node);
        }

        private void tvFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null)
            {
                string path = e.Node.Tag.ToString();
                if (System.IO.Directory.Exists(path))
                {
                    TaiThuMucVaFile(e.Node);
                    e.Node.Expand();
                }
            }
        }

        private void tvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Tag == null) return;
            string path = e.Node.Tag.ToString();

            if (!System.IO.File.Exists(path))
            {
                picFile.Visible = false;
                rtbFile.Visible = false;
                return;
            }

            string ext = System.IO.Path.GetExtension(path).ToLower();
            string[] duoiHinhAnh = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string[] duoiVanBan = { ".txt", ".cs", ".json", ".xml", ".html", ".log" };

            try
            {
                if (Array.Exists(duoiHinhAnh, E => E == ext))
                {
                    rtbFile.Visible = false;
                    picFile.Visible = true;
                    picFile.BringToFront();

                    if (picFile.Image != null)
                    {
                        picFile.Image.Dispose();
                        picFile.Image = null;
                    }

                    using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        picFile.Image = System.Drawing.Image.FromStream(fs);
                    }
                }
                else if (Array.Exists(duoiVanBan, E => E == ext))
                {
                    picFile.Visible = false;
                    rtbFile.Visible = true;
                    rtbFile.BringToFront();
                    rtbFile.Text = System.IO.File.ReadAllText(path, System.Text.Encoding.UTF8);
                }
                else
                {
                    picFile.Visible = false;
                    rtbFile.Visible = true;
                    rtbFile.BringToFront();
                    System.IO.FileInfo fi = new System.IO.FileInfo(path);
                    rtbFile.Text = $"[Không hỗ trợ xem trước định dạng {ext}]\n\n" +
                                   $"- Tên file: {fi.Name}\n" +
                                   $"- Kích thước: {fi.Length:N0} bytes\n" +
                                   $"- Ngày chỉnh sửa: {fi.LastWriteTime:dd/MM/yyyy HH:mm:ss}";
                }
            }
            catch (Exception ex)
            {
                picFile.Visible = false;
                rtbFile.Visible = true;
                rtbFile.BringToFront();
                rtbFile.Text = $"Không thể đọc nội dung file này.\nChi tiết lỗi: {ex.Message}";
            }
        }
    }
}
