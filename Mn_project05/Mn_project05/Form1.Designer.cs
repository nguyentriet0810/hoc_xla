namespace Mn_project05
{
    partial class Histogram_Grayscale
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
            this.picBox_hinhgoc = new System.Windows.Forms.PictureBox();
            this.picBox_Grayscale_Average = new System.Windows.Forms.PictureBox();
            this.lblhinhgoc = new System.Windows.Forms.Label();
            this.lblhinhmucxam = new System.Windows.Forms.Label();
            this.zG_Histogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Grayscale_Average)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_hinhgoc
            // 
            this.picBox_hinhgoc.Location = new System.Drawing.Point(3, 12);
            this.picBox_hinhgoc.Name = "picBox_hinhgoc";
            this.picBox_hinhgoc.Size = new System.Drawing.Size(512, 381);
            this.picBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhgoc.TabIndex = 0;
            this.picBox_hinhgoc.TabStop = false;
            // 
            // picBox_Grayscale_Average
            // 
            this.picBox_Grayscale_Average.Location = new System.Drawing.Point(3, 399);
            this.picBox_Grayscale_Average.Name = "picBox_Grayscale_Average";
            this.picBox_Grayscale_Average.Size = new System.Drawing.Size(512, 381);
            this.picBox_Grayscale_Average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Grayscale_Average.TabIndex = 2;
            this.picBox_Grayscale_Average.TabStop = false;
            // 
            // lblhinhgoc
            // 
            this.lblhinhgoc.AutoSize = true;
            this.lblhinhgoc.Location = new System.Drawing.Point(12, 12);
            this.lblhinhgoc.Name = "lblhinhgoc";
            this.lblhinhgoc.Size = new System.Drawing.Size(129, 17);
            this.lblhinhgoc.TabIndex = 3;
            this.lblhinhgoc.Text = "Hinh goc RGB lena";
            // 
            // lblhinhmucxam
            // 
            this.lblhinhmucxam.AutoSize = true;
            this.lblhinhmucxam.Location = new System.Drawing.Point(12, 399);
            this.lblhinhmucxam.Name = "lblhinhmucxam";
            this.lblhinhmucxam.Size = new System.Drawing.Size(96, 17);
            this.lblhinhmucxam.TabIndex = 4;
            this.lblhinhmucxam.Text = "Hinh muc xam";
            // 
            // zG_Histogram
            // 
            this.zG_Histogram.Location = new System.Drawing.Point(522, 12);
            this.zG_Histogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zG_Histogram.Name = "zG_Histogram";
            this.zG_Histogram.ScrollGrace = 0D;
            this.zG_Histogram.ScrollMaxX = 0D;
            this.zG_Histogram.ScrollMaxY = 0D;
            this.zG_Histogram.ScrollMaxY2 = 0D;
            this.zG_Histogram.ScrollMinX = 0D;
            this.zG_Histogram.ScrollMinY = 0D;
            this.zG_Histogram.ScrollMinY2 = 0D;
            this.zG_Histogram.Size = new System.Drawing.Size(1047, 723);
            this.zG_Histogram.TabIndex = 5;
            this.zG_Histogram.UseExtendedPrintDialog = true;
            // 
            // Histogram_Grayscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 803);
            this.Controls.Add(this.zG_Histogram);
            this.Controls.Add(this.lblhinhmucxam);
            this.Controls.Add(this.lblhinhgoc);
            this.Controls.Add(this.picBox_Grayscale_Average);
            this.Controls.Add(this.picBox_hinhgoc);
            this.Name = "Histogram_Grayscale";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Grayscale_Average)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_hinhgoc;
        private System.Windows.Forms.PictureBox picBox_Grayscale_Average;
        private System.Windows.Forms.Label lblhinhgoc;
        private System.Windows.Forms.Label lblhinhmucxam;
        private ZedGraph.ZedGraphControl zG_Histogram;
    }
}

