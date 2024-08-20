using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// khai bao thu vien
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace mn_project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // tao chuoi luu file hinh
            string linkhinh = @"F:\xu_ly_anh\lena_color.png";
            // tao bien chua hinh dc load
            Bitmap hinhgoc = new Bitmap(linkhinh);
            
            // khai bao 3 hinh red green blue
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            // xu ly tach mau
            // quet anh
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //doc gia tri pixel 
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte A = pixel.A;

                    // set gia tri doc duoc cho cac hinh tuong ung
                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));
                }
            }
            // hien thi hinh
            pictureBox_hinhgoc.Image = hinhgoc;
            pictureBox_red.Image = red;
            pictureBox_green.Image = green;
            pictureBox_blue.Image = blue;
        }
    }
}
