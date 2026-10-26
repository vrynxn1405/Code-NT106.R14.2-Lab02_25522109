namespace Lab02
{
    partial class Bai6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuyenHan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.txtNguoiDG = new System.Windows.Forms.TextBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnTimMon = new System.Windows.Forms.Button();
            this.lblKetQuaMon = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKetQuaNCC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(181, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 30);
            this.txtName.TabIndex = 0;
            // 
            // txtQuyenHan
            // 
            this.txtQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyenHan.Location = new System.Drawing.Point(181, 105);
            this.txtQuyenHan.Name = "txtQuyenHan";
            this.txtQuyenHan.Size = new System.Drawing.Size(188, 30);
            this.txtQuyenHan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quyền hạn:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(93, 154);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(195, 37);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Thêm người dùng";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "NGƯỜI DÙNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "THÊM MÓN ĂN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên món ăn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Người đóng góp:";
            // 
            // txtFood
            // 
            this.txtFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.Location = new System.Drawing.Point(181, 245);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(188, 30);
            this.txtFood.TabIndex = 9;
            // 
            // txtNguoiDG
            // 
            this.txtNguoiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiDG.Location = new System.Drawing.Point(181, 286);
            this.txtNguoiDG.Name = "txtNguoiDG";
            this.txtNguoiDG.Size = new System.Drawing.Size(188, 30);
            this.txtNguoiDG.TabIndex = 10;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(93, 322);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(195, 37);
            this.btnAddFood.TabIndex = 11;
            this.btnAddFood.Text = "Thêm món ăn:";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(390, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 118);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnTimMon
            // 
            this.btnTimMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMon.Location = new System.Drawing.Point(524, 203);
            this.btnTimMon.Name = "btnTimMon";
            this.btnTimMon.Size = new System.Drawing.Size(190, 29);
            this.btnTimMon.TabIndex = 13;
            this.btnTimMon.Text = "Tìm món ăn!";
            this.btnTimMon.UseVisualStyleBackColor = true;
            this.btnTimMon.Click += new System.EventHandler(this.btnTimMon_Click);
            // 
            // lblKetQuaMon
            // 
            this.lblKetQuaMon.AutoSize = true;
            this.lblKetQuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaMon.Location = new System.Drawing.Point(582, 245);
            this.lblKetQuaMon.Name = "lblKetQuaMon";
            this.lblKetQuaMon.Size = new System.Drawing.Size(132, 25);
            this.lblKetQuaMon.TabIndex = 14;
            this.lblKetQuaMon.Text = "( Chưa chọn )";
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(524, 322);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(230, 92);
            this.picFood.TabIndex = 16;
            this.picFood.TabStop = false;
            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaToanBo.Location = new System.Drawing.Point(271, 377);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(194, 37);
            this.btnXoaToanBo.TabIndex = 17;
            this.btnXoaToanBo.Text = "Xoá toàn bộ dữ liệu";
            this.btnXoaToanBo.UseVisualStyleBackColor = true;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(385, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "DANH SÁCH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(385, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "KẾT QUẢ";
            // 
            // lblKetQuaNCC
            // 
            this.lblKetQuaNCC.AutoSize = true;
            this.lblKetQuaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaNCC.Location = new System.Drawing.Point(582, 286);
            this.lblKetQuaNCC.Name = "lblKetQuaNCC";
            this.lblKetQuaNCC.Size = new System.Drawing.Size(132, 25);
            this.lblKetQuaNCC.TabIndex = 20;
            this.lblKetQuaNCC.Text = "( Chưa chọn )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên món ăn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(413, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Người đóng góp:";
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblKetQuaNCC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoaToanBo);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lblKetQuaMon);
            this.Controls.Add(this.btnTimMon);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.txtNguoiDG);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuyenHan);
            this.Controls.Add(this.txtName);
            this.Name = "Bai6";
            this.Text = "Bai6";
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuyenHan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.TextBox txtNguoiDG;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnTimMon;
        private System.Windows.Forms.Label lblKetQuaMon;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Button btnXoaToanBo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKetQuaNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}