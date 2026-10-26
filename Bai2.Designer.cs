namespace Lab02
{
    partial class Bai2
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
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtWordsCount = new System.Windows.Forms.TextBox();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFromFile.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReadFromFile.Location = new System.Drawing.Point(41, 12);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(417, 40);
            this.btnReadFromFile.TabIndex = 0;
            this.btnReadFromFile.Text = "Read from File";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnExit.Location = new System.Drawing.Point(41, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(417, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(190, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 30);
            this.txtName.TabIndex = 2;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(190, 124);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(268, 30);
            this.txtSize.TabIndex = 3;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(190, 178);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(268, 30);
            this.txtURL.TabIndex = 4;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineCount.Location = new System.Drawing.Point(190, 233);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.Size = new System.Drawing.Size(268, 30);
            this.txtLineCount.TabIndex = 5;
            // 
            // txtWordsCount
            // 
            this.txtWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsCount.Location = new System.Drawing.Point(190, 287);
            this.txtWordsCount.Name = "txtWordsCount";
            this.txtWordsCount.Size = new System.Drawing.Size(268, 30);
            this.txtWordsCount.TabIndex = 6;
            // 
            // txtCharCount
            // 
            this.txtCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharCount.Location = new System.Drawing.Point(190, 336);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.Size = new System.Drawing.Size(268, 30);
            this.txtCharCount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(36, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(36, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Line Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(36, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Words Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(36, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Char Count";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(482, 12);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(284, 416);
            this.rtbContent.TabIndex = 14;
            this.rtbContent.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCharCount);
            this.Controls.Add(this.txtWordsCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFromFile);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.TextBox txtWordsCount;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}