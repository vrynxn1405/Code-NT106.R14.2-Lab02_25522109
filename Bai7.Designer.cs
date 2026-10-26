namespace Lab02
{
    partial class Bai7
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
            this.tvFolder = new System.Windows.Forms.TreeView();
            this.picFile = new System.Windows.Forms.PictureBox();
            this.rtbFile = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            this.SuspendLayout();
            // 
            // tvFolder
            // 
            this.tvFolder.Location = new System.Drawing.Point(70, 49);
            this.tvFolder.Name = "tvFolder";
            this.tvFolder.Size = new System.Drawing.Size(321, 350);
            this.tvFolder.TabIndex = 0;
            // 
            // picFile
            // 
            this.picFile.Location = new System.Drawing.Point(452, 49);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(272, 198);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFile.TabIndex = 1;
            this.picFile.TabStop = false;
            // 
            // rtbFile
            // 
            this.rtbFile.Location = new System.Drawing.Point(452, 49);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.Size = new System.Drawing.Size(272, 198);
            this.rtbFile.TabIndex = 2;
            this.rtbFile.Text = "";
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFile);
            this.Controls.Add(this.picFile);
            this.Controls.Add(this.tvFolder);
            this.Name = "Bai7";
            this.Text = "Bai7";
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvFolder;
        private System.Windows.Forms.PictureBox picFile;
        private System.Windows.Forms.RichTextBox rtbFile;
    }
}