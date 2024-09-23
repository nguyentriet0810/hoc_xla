namespace mn_project01
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
            this.picBox_green = new System.Windows.Forms.PictureBox();
            this.picBox_red = new System.Windows.Forms.PictureBox();
            this.picBox_blue = new System.Windows.Forms.PictureBox();
            this.lbl_hinhgoc = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_hinhgoc
            // 
            this.picBox_hinhgoc.Location = new System.Drawing.Point(12, 53);
            this.picBox_hinhgoc.Name = "picBox_hinhgoc";
            this.picBox_hinhgoc.Size = new System.Drawing.Size(256, 256);
            this.picBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhgoc.TabIndex = 0;
            this.picBox_hinhgoc.TabStop = false;
            // 
            // picBox_green
            // 
            this.picBox_green.Location = new System.Drawing.Point(12, 345);
            this.picBox_green.Name = "picBox_green";
            this.picBox_green.Size = new System.Drawing.Size(256, 256);
            this.picBox_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_green.TabIndex = 1;
            this.picBox_green.TabStop = false;
            // 
            // picBox_red
            // 
            this.picBox_red.Location = new System.Drawing.Point(286, 53);
            this.picBox_red.Name = "picBox_red";
            this.picBox_red.Size = new System.Drawing.Size(256, 256);
            this.picBox_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_red.TabIndex = 2;
            this.picBox_red.TabStop = false;
            // 
            // picBox_blue
            // 
            this.picBox_blue.Location = new System.Drawing.Point(286, 345);
            this.picBox_blue.Name = "picBox_blue";
            this.picBox_blue.Size = new System.Drawing.Size(256, 256);
            this.picBox_blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_blue.TabIndex = 3;
            this.picBox_blue.TabStop = false;
            // 
            // lbl_hinhgoc
            // 
            this.lbl_hinhgoc.AutoSize = true;
            this.lbl_hinhgoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hinhgoc.Location = new System.Drawing.Point(12, 33);
            this.lbl_hinhgoc.Name = "lbl_hinhgoc";
            this.lbl_hinhgoc.Size = new System.Drawing.Size(179, 20);
            this.lbl_hinhgoc.TabIndex = 4;
            this.lbl_hinhgoc.Text = "Hinh Goc Co Gai Lena";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.ForeColor = System.Drawing.Color.Red;
            this.lbl_red.Location = new System.Drawing.Point(282, 33);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(122, 20);
            this.lbl_red.TabIndex = 5;
            this.lbl_red.Text = "Hinh Kenh Red";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.ForeColor = System.Drawing.Color.Lime;
            this.lbl_green.Location = new System.Drawing.Point(12, 322);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(138, 20);
            this.lbl_green.TabIndex = 6;
            this.lbl_green.Text = "Hinh Kenh Green";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_blue.Location = new System.Drawing.Point(282, 322);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(126, 20);
            this.lbl_blue.TabIndex = 7;
            this.lbl_blue.Text = "Hinh Kenh Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 653);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.lbl_hinhgoc);
            this.Controls.Add(this.picBox_blue);
            this.Controls.Add(this.picBox_red);
            this.Controls.Add(this.picBox_green);
            this.Controls.Add(this.picBox_hinhgoc);
            this.Name = "Form1";
            this.Text = "Tach Anh RGB";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_hinhgoc;
        private System.Windows.Forms.PictureBox picBox_green;
        private System.Windows.Forms.PictureBox picBox_red;
        private System.Windows.Forms.PictureBox picBox_blue;
        private System.Windows.Forms.Label lbl_hinhgoc;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_blue;
    }
}

