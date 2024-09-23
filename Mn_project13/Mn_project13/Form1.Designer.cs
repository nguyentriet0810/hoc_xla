namespace Mn_project13
{
    partial class Form1
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
            this.picBox_hinhgoc = new System.Windows.Forms.PictureBox();
            this.lbl_hinhgoc = new System.Windows.Forms.Label();
            this.picBox_hinhphandoan = new System.Windows.Forms.PictureBox();
            this.lbl_phandoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhphandoan)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_hinhgoc
            // 
            this.picBox_hinhgoc.Location = new System.Drawing.Point(15, 29);
            this.picBox_hinhgoc.Name = "picBox_hinhgoc";
            this.picBox_hinhgoc.Size = new System.Drawing.Size(512, 512);
            this.picBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhgoc.TabIndex = 0;
            this.picBox_hinhgoc.TabStop = false;
            // 
            // lbl_hinhgoc
            // 
            this.lbl_hinhgoc.AutoSize = true;
            this.lbl_hinhgoc.Location = new System.Drawing.Point(12, 9);
            this.lbl_hinhgoc.Name = "lbl_hinhgoc";
            this.lbl_hinhgoc.Size = new System.Drawing.Size(142, 17);
            this.lbl_hinhgoc.TabIndex = 1;
            this.lbl_hinhgoc.Text = "Hinh goc co gai Lena";
            // 
            // picBox_hinhphandoan
            // 
            this.picBox_hinhphandoan.Location = new System.Drawing.Point(533, 29);
            this.picBox_hinhphandoan.Name = "picBox_hinhphandoan";
            this.picBox_hinhphandoan.Size = new System.Drawing.Size(512, 512);
            this.picBox_hinhphandoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhphandoan.TabIndex = 2;
            this.picBox_hinhphandoan.TabStop = false;
            // 
            // lbl_phandoan
            // 
            this.lbl_phandoan.AutoSize = true;
            this.lbl_phandoan.Location = new System.Drawing.Point(530, 9);
            this.lbl_phandoan.Name = "lbl_phandoan";
            this.lbl_phandoan.Size = new System.Drawing.Size(144, 17);
            this.lbl_phandoan.TabIndex = 3;
            this.lbl_phandoan.Text = "Hinh duoc phan doan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 555);
            this.Controls.Add(this.lbl_phandoan);
            this.Controls.Add(this.picBox_hinhphandoan);
            this.Controls.Add(this.lbl_hinhgoc);
            this.Controls.Add(this.picBox_hinhgoc);
            this.Name = "Form1";
            this.Text = "Phan Doan Anh Mau RGB";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhphandoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_hinhgoc;
        private System.Windows.Forms.Label lbl_hinhgoc;
        private System.Windows.Forms.PictureBox picBox_hinhphandoan;
        private System.Windows.Forms.Label lbl_phandoan;
    }
}

