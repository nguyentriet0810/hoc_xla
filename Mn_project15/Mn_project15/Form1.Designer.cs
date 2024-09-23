namespace Mn_project15
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
            this.picBox_nhandang = new System.Windows.Forms.PictureBox();
            this.lbl_hinhgoc = new System.Windows.Forms.Label();
            this.lbl_nhandang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_nhandang)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_hinhgoc
            // 
            this.picBox_hinhgoc.Location = new System.Drawing.Point(12, 49);
            this.picBox_hinhgoc.Name = "picBox_hinhgoc";
            this.picBox_hinhgoc.Size = new System.Drawing.Size(512, 512);
            this.picBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhgoc.TabIndex = 0;
            this.picBox_hinhgoc.TabStop = false;
            // 
            // picBox_nhandang
            // 
            this.picBox_nhandang.Location = new System.Drawing.Point(530, 49);
            this.picBox_nhandang.Name = "picBox_nhandang";
            this.picBox_nhandang.Size = new System.Drawing.Size(512, 512);
            this.picBox_nhandang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_nhandang.TabIndex = 1;
            this.picBox_nhandang.TabStop = false;
            // 
            // lbl_hinhgoc
            // 
            this.lbl_hinhgoc.AutoSize = true;
            this.lbl_hinhgoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hinhgoc.ForeColor = System.Drawing.Color.Red;
            this.lbl_hinhgoc.Location = new System.Drawing.Point(12, 20);
            this.lbl_hinhgoc.Name = "lbl_hinhgoc";
            this.lbl_hinhgoc.Size = new System.Drawing.Size(208, 25);
            this.lbl_hinhgoc.TabIndex = 2;
            this.lbl_hinhgoc.Text = "Hinh Goc Co Gai Lena";
            // 
            // lbl_nhandang
            // 
            this.lbl_nhandang.AutoSize = true;
            this.lbl_nhandang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhandang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nhandang.Location = new System.Drawing.Point(525, 21);
            this.lbl_nhandang.Name = "lbl_nhandang";
            this.lbl_nhandang.Size = new System.Drawing.Size(263, 25);
            this.lbl_nhandang.TabIndex = 3;
            this.lbl_nhandang.Text = "Hinh Nhan Dang Duong Bien";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 573);
            this.Controls.Add(this.lbl_nhandang);
            this.Controls.Add(this.lbl_hinhgoc);
            this.Controls.Add(this.picBox_nhandang);
            this.Controls.Add(this.picBox_hinhgoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_nhandang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_hinhgoc;
        private System.Windows.Forms.PictureBox picBox_nhandang;
        private System.Windows.Forms.Label lbl_hinhgoc;
        private System.Windows.Forms.Label lbl_nhandang;
    }
}

