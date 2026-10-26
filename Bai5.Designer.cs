namespace Lab02
{
    partial class Bai5
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbPhim = new System.Windows.Forms.ComboBox();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.clbGhe = new System.Windows.Forms.CheckedListBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(55, 24);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(315, 32);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "ĐỌC FILE";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.Location = new System.Drawing.Point(55, 386);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(315, 32);
            this.btnDatVe.TabIndex = 1;
            this.btnDatVe.Text = "XÁC NHẬN ĐẶT VÉ";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(449, 386);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(314, 32);
            this.btnXuatFile.TabIndex = 2;
            this.btnXuatFile.Text = "XUẤT FILE";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(204, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 30);
            this.txtName.TabIndex = 3;
            // 
            // cbPhim
            // 
            this.cbPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhim.FormattingEnabled = true;
            this.cbPhim.Location = new System.Drawing.Point(204, 123);
            this.cbPhim.Name = "cbPhim";
            this.cbPhim.Size = new System.Drawing.Size(213, 33);
            this.cbPhim.TabIndex = 4;
            this.cbPhim.Click += new System.EventHandler(this.cbPhim_SelectedIndexChanged);
            // 
            // cbRoom
            // 
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(204, 173);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(213, 33);
            this.cbRoom.TabIndex = 5;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged_1);
            this.cbRoom.Click += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // clbGhe
            // 
            this.clbGhe.FormattingEnabled = true;
            this.clbGhe.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5"});
            this.clbGhe.Location = new System.Drawing.Point(55, 257);
            this.clbGhe.MultiColumn = true;
            this.clbGhe.Name = "clbGhe";
            this.clbGhe.Size = new System.Drawing.Size(362, 123);
            this.clbGhe.TabIndex = 6;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(449, 24);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(314, 263);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(465, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(285, 28);
            this.progressBar1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ và tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chọn phim: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chọn phòng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chọn ghế: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiến trình xuất file:";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.clbGhe);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.cbPhim);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnRead);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbPhim;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.CheckedListBox clbGhe;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}