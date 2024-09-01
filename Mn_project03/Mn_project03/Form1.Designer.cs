namespace Mn_project03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_anhgoc = new System.Windows.Forms.PictureBox();
            this.pictureBox_GrayAverage = new System.Windows.Forms.PictureBox();
            this.pictureBox_Lightness = new System.Windows.Forms.PictureBox();
            this.pictureBox_Luminance = new System.Windows.Forms.PictureBox();
            this.lbl_RGB = new System.Windows.Forms.Label();
            this.lbl_GrayAverage = new System.Windows.Forms.Label();
            this.lbl_gray_lightness = new System.Windows.Forms.Label();
            this.lbl_gray_Luminance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GrayAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_anhgoc
            // 
            resources.ApplyResources(this.pictureBox_anhgoc, "pictureBox_anhgoc");
            this.pictureBox_anhgoc.Name = "pictureBox_anhgoc";
            this.pictureBox_anhgoc.TabStop = false;
            this.pictureBox_anhgoc.Click += new System.EventHandler(this.pictureBox_anhgoc_Click);
            // 
            // pictureBox_GrayAverage
            // 
            resources.ApplyResources(this.pictureBox_GrayAverage, "pictureBox_GrayAverage");
            this.pictureBox_GrayAverage.Name = "pictureBox_GrayAverage";
            this.pictureBox_GrayAverage.TabStop = false;
            // 
            // pictureBox_Lightness
            // 
            resources.ApplyResources(this.pictureBox_Lightness, "pictureBox_Lightness");
            this.pictureBox_Lightness.Name = "pictureBox_Lightness";
            this.pictureBox_Lightness.TabStop = false;
            // 
            // pictureBox_Luminance
            // 
            resources.ApplyResources(this.pictureBox_Luminance, "pictureBox_Luminance");
            this.pictureBox_Luminance.Name = "pictureBox_Luminance";
            this.pictureBox_Luminance.TabStop = false;
            // 
            // lbl_RGB
            // 
            resources.ApplyResources(this.lbl_RGB, "lbl_RGB");
            this.lbl_RGB.Name = "lbl_RGB";
            // 
            // lbl_GrayAverage
            // 
            resources.ApplyResources(this.lbl_GrayAverage, "lbl_GrayAverage");
            this.lbl_GrayAverage.Name = "lbl_GrayAverage";
            // 
            // lbl_gray_lightness
            // 
            resources.ApplyResources(this.lbl_gray_lightness, "lbl_gray_lightness");
            this.lbl_gray_lightness.Name = "lbl_gray_lightness";
            // 
            // lbl_gray_Luminance
            // 
            resources.ApplyResources(this.lbl_gray_Luminance, "lbl_gray_Luminance");
            this.lbl_gray_Luminance.Name = "lbl_gray_Luminance";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_gray_Luminance);
            this.Controls.Add(this.lbl_gray_lightness);
            this.Controls.Add(this.lbl_GrayAverage);
            this.Controls.Add(this.lbl_RGB);
            this.Controls.Add(this.pictureBox_Luminance);
            this.Controls.Add(this.pictureBox_Lightness);
            this.Controls.Add(this.pictureBox_GrayAverage);
            this.Controls.Add(this.pictureBox_anhgoc);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GrayAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_anhgoc;
        private System.Windows.Forms.PictureBox pictureBox_GrayAverage;
        private System.Windows.Forms.PictureBox pictureBox_Lightness;
        public System.Windows.Forms.PictureBox pictureBox_Luminance;
        private System.Windows.Forms.Label lbl_RGB;
        private System.Windows.Forms.Label lbl_GrayAverage;
        private System.Windows.Forms.Label lbl_gray_lightness;
        private System.Windows.Forms.Label lbl_gray_Luminance;
    }
}

