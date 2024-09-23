namespace Mn_project14
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
            this.picBoc_hinhgoc = new System.Windows.Forms.PictureBox();
            this.picBox_duongbien = new System.Windows.Forms.PictureBox();
            this.lbl_hinhgoc = new System.Windows.Forms.Label();
            this.lbl_nhandang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoc_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_duongbien)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoc_hinhgoc
            // 
            this.picBoc_hinhgoc.Location = new System.Drawing.Point(12, 46);
            this.picBoc_hinhgoc.Name = "picBoc_hinhgoc";
            this.picBoc_hinhgoc.Size = new System.Drawing.Size(512, 512);
            this.picBoc_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoc_hinhgoc.TabIndex = 0;
            this.picBoc_hinhgoc.TabStop = false;
            // 
            // picBox_duongbien
            // 
            this.picBox_duongbien.Location = new System.Drawing.Point(545, 46);
            this.picBox_duongbien.Name = "picBox_duongbien";
            this.picBox_duongbien.Size = new System.Drawing.Size(512, 512);
            this.picBox_duongbien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_duongbien.TabIndex = 1;
            this.picBox_duongbien.TabStop = false;
            // 
            // lbl_hinhgoc
            // 
            this.lbl_hinhgoc.AutoSize = true;
            this.lbl_hinhgoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hinhgoc.ForeColor = System.Drawing.Color.Red;
            this.lbl_hinhgoc.Location = new System.Drawing.Point(12, 18);
            this.lbl_hinhgoc.Name = "lbl_hinhgoc";
            this.lbl_hinhgoc.Size = new System.Drawing.Size(208, 25);
            this.lbl_hinhgoc.TabIndex = 2;
            this.lbl_hinhgoc.Text = "Hinh Goc Co Gai Lena";
            // 
            // lbl_nhandang
            // 
            this.lbl_nhandang.AutoSize = true;
            this.lbl_nhandang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhandang.ForeColor = System.Drawing.Color.Black;
            this.lbl_nhandang.Location = new System.Drawing.Point(540, 18);
            this.lbl_nhandang.Name = "lbl_nhandang";
            this.lbl_nhandang.Size = new System.Drawing.Size(263, 25);
            this.lbl_nhandang.TabIndex = 3;
            this.lbl_nhandang.Text = "Hinh Nhan Dang Duong Bien";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 576);
            this.Controls.Add(this.lbl_nhandang);
            this.Controls.Add(this.lbl_hinhgoc);
            this.Controls.Add(this.picBox_duongbien);
            this.Controls.Add(this.picBoc_hinhgoc);
            this.Name = "Form1";
            this.Text = "Nhan Dang Duong Bien";
            ((System.ComponentModel.ISupportInitialize)(this.picBoc_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_duongbien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoc_hinhgoc;
        private System.Windows.Forms.PictureBox picBox_duongbien;
        private System.Windows.Forms.Label lbl_hinhgoc;
        private System.Windows.Forms.Label lbl_nhandang;
    }
}

