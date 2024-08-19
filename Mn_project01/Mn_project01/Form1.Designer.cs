namespace Mn_project01
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
            this.components = new System.ComponentModel.Container();
            this.imageBox_hienthi = new Emgu.CV.UI.ImageBox();
            this.lblhienthi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox_hienthi
            // 
            this.imageBox_hienthi.Location = new System.Drawing.Point(156, 44);
            this.imageBox_hienthi.Name = "imageBox_hienthi";
            this.imageBox_hienthi.Size = new System.Drawing.Size(512, 512);
            this.imageBox_hienthi.TabIndex = 2;
            this.imageBox_hienthi.TabStop = false;
            // 
            // lblhienthi
            // 
            this.lblhienthi.AutoSize = true;
            this.lblhienthi.Location = new System.Drawing.Point(153, 24);
            this.lblhienthi.Name = "lblhienthi";
            this.lblhienthi.Size = new System.Drawing.Size(79, 17);
            this.lblhienthi.TabIndex = 3;
            this.lblhienthi.Text = "Hinhhienthi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 622);
            this.Controls.Add(this.lblhienthi);
            this.Controls.Add(this.imageBox_hienthi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox_hienthi;
        private System.Windows.Forms.Label lblhienthi;
    }
}

