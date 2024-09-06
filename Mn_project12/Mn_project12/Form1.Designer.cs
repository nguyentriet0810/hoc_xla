namespace Mn_project12
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
            this.picBox_hinhlamsacnet = new System.Windows.Forms.PictureBox();
            this.lbl_hinhgoc = new System.Windows.Forms.Label();
            this.lbl_sacnet = new System.Windows.Forms.Label();
            this.b_lamsacnet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhlamsacnet)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_hinhgoc
            // 
            this.picBox_hinhgoc.Location = new System.Drawing.Point(12, 40);
            this.picBox_hinhgoc.Name = "picBox_hinhgoc";
            this.picBox_hinhgoc.Size = new System.Drawing.Size(512, 512);
            this.picBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhgoc.TabIndex = 0;
            this.picBox_hinhgoc.TabStop = false;
            // 
            // picBox_hinhlamsacnet
            // 
            this.picBox_hinhlamsacnet.Location = new System.Drawing.Point(558, 40);
            this.picBox_hinhlamsacnet.Name = "picBox_hinhlamsacnet";
            this.picBox_hinhlamsacnet.Size = new System.Drawing.Size(512, 512);
            this.picBox_hinhlamsacnet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhlamsacnet.TabIndex = 4;
            this.picBox_hinhlamsacnet.TabStop = false;
            // 
            // lbl_hinhgoc
            // 
            this.lbl_hinhgoc.AutoSize = true;
            this.lbl_hinhgoc.Location = new System.Drawing.Point(12, 20);
            this.lbl_hinhgoc.Name = "lbl_hinhgoc";
            this.lbl_hinhgoc.Size = new System.Drawing.Size(144, 17);
            this.lbl_hinhgoc.TabIndex = 5;
            this.lbl_hinhgoc.Text = "Hinh goc Co gai Lena";
            // 
            // lbl_sacnet
            // 
            this.lbl_sacnet.AutoSize = true;
            this.lbl_sacnet.Location = new System.Drawing.Point(555, 20);
            this.lbl_sacnet.Name = "lbl_sacnet";
            this.lbl_sacnet.Size = new System.Drawing.Size(148, 17);
            this.lbl_sacnet.TabIndex = 6;
            this.lbl_sacnet.Text = "Hinh duoc lam sac net";
            // 
            // b_lamsacnet
            // 
            this.b_lamsacnet.Location = new System.Drawing.Point(1085, 40);
            this.b_lamsacnet.Name = "b_lamsacnet";
            this.b_lamsacnet.Size = new System.Drawing.Size(75, 61);
            this.b_lamsacnet.TabIndex = 7;
            this.b_lamsacnet.Text = "Lam sac net";
            this.b_lamsacnet.UseVisualStyleBackColor = true;
            this.b_lamsacnet.Click += new System.EventHandler(this.b_lamsacnet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 564);
            this.Controls.Add(this.b_lamsacnet);
            this.Controls.Add(this.lbl_sacnet);
            this.Controls.Add(this.lbl_hinhgoc);
            this.Controls.Add(this.picBox_hinhlamsacnet);
            this.Controls.Add(this.picBox_hinhgoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhlamsacnet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_hinhgoc;
        private System.Windows.Forms.PictureBox picBox_hinhlamsacnet;
        private System.Windows.Forms.Label lbl_hinhgoc;
        private System.Windows.Forms.Label lbl_sacnet;
        private System.Windows.Forms.Button b_lamsacnet;
    }
}

