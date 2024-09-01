namespace Mn_project04
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
            this.picBox_anh_goc = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picBox_Binary = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblthreshold = new System.Windows.Forms.Label();
            this.giatrithreshold = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_anh_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Binary)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_anh_goc
            // 
            this.picBox_anh_goc.Location = new System.Drawing.Point(12, 84);
            this.picBox_anh_goc.Name = "picBox_anh_goc";
            this.picBox_anh_goc.Size = new System.Drawing.Size(512, 512);
            this.picBox_anh_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_anh_goc.TabIndex = 0;
            this.picBox_anh_goc.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 417);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // picBox_Binary
            // 
            this.picBox_Binary.Location = new System.Drawing.Point(544, 84);
            this.picBox_Binary.Name = "picBox_Binary";
            this.picBox_Binary.Size = new System.Drawing.Size(512, 512);
            this.picBox_Binary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Binary.TabIndex = 2;
            this.picBox_Binary.TabStop = false;
            this.picBox_Binary.Click += new System.EventHandler(this.picBox_Binary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anh goc RGB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anh Binary";
            // 
            // lblthreshold
            // 
            this.lblthreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthreshold.Location = new System.Drawing.Point(1100, 84);
            this.lblthreshold.Name = "lblthreshold";
            this.lblthreshold.Size = new System.Drawing.Size(50, 20);
            this.lblthreshold.TabIndex = 6;
            // 
            // giatrithreshold
            // 
            this.giatrithreshold.Location = new System.Drawing.Point(1068, 84);
            this.giatrithreshold.Maximum = 255;
            this.giatrithreshold.Name = "giatrithreshold";
            this.giatrithreshold.Size = new System.Drawing.Size(29, 511);
            this.giatrithreshold.TabIndex = 7;
            this.giatrithreshold.ValueChanged += new System.EventHandler(this.giatrithreshold_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.giatrithreshold);
            this.Controls.Add(this.lblthreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_Binary);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.picBox_anh_goc);
            this.Name = "Form1";
            this.Text = "RGB to Binary";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_anh_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Binary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_anh_goc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox picBox_Binary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblthreshold;
        private System.Windows.Forms.VScrollBar giatrithreshold;
    }
}

