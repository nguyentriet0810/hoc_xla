namespace Mn_projec05_part2
{
    partial class lbl_Histogram_RGB
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
            this.zG_Histogram = new ZedGraph.ZedGraphControl();
            this.lbl_hinhgoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_hinhgoc
            // 
            this.picBox_hinhgoc.Location = new System.Drawing.Point(3, 19);
            this.picBox_hinhgoc.Name = "picBox_hinhgoc";
            this.picBox_hinhgoc.Size = new System.Drawing.Size(500, 381);
            this.picBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_hinhgoc.TabIndex = 0;
            this.picBox_hinhgoc.TabStop = false;
            // 
            // zG_Histogram
            // 
            this.zG_Histogram.Location = new System.Drawing.Point(510, 19);
            this.zG_Histogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zG_Histogram.Name = "zG_Histogram";
            this.zG_Histogram.ScrollGrace = 0D;
            this.zG_Histogram.ScrollMaxX = 0D;
            this.zG_Histogram.ScrollMaxY = 0D;
            this.zG_Histogram.ScrollMaxY2 = 0D;
            this.zG_Histogram.ScrollMinX = 0D;
            this.zG_Histogram.ScrollMinY = 0D;
            this.zG_Histogram.ScrollMinY2 = 0D;
            this.zG_Histogram.Size = new System.Drawing.Size(1038, 671);
            this.zG_Histogram.TabIndex = 4;
            this.zG_Histogram.UseExtendedPrintDialog = true;
            // 
            // lbl_hinhgoc
            // 
            this.lbl_hinhgoc.AutoSize = true;
            this.lbl_hinhgoc.Location = new System.Drawing.Point(12, 12);
            this.lbl_hinhgoc.Name = "lbl_hinhgoc";
            this.lbl_hinhgoc.Size = new System.Drawing.Size(161, 17);
            this.lbl_hinhgoc.TabIndex = 5;
            this.lbl_hinhgoc.Text = "Hinh Goc Con Chim Nho";
            // 
            // lbl_Histogram_RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1582, 703);
            this.Controls.Add(this.lbl_hinhgoc);
            this.Controls.Add(this.zG_Histogram);
            this.Controls.Add(this.picBox_hinhgoc);
            this.Name = "lbl_Histogram_RGB";
            this.Text = "Histogram_RGB";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hinhgoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_hinhgoc;
        private ZedGraph.ZedGraphControl zG_Histogram;
        private System.Windows.Forms.Label lbl_hinhgoc;
    }
}

