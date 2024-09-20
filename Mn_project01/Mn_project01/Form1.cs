using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mn_project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //khai bao chuoi chua link hinh
            string linkhinh = @"D:\hoc_xla\lena_color.png";

            //Tao bien co kieu du lieu la bitmap de luu hinh
            Bitmap hinhgoc = new Bitmap(linkhinh);

            //Tao them bien co kdl la bitmap de luu hinh cac kenh R G B
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //Hien thhi hinh anh
            picBox_hinhgoc.Image = hinhgoc;

            //tach mau RGB
            //quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lay gia tri cua diem anh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //set gia tri diem anh
                    red.SetPixel(x, y, Color.FromArgb(R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(0, 0, B));
                }
            }

            //hien thi hinh anh cua tung kenh
            picBox_red.Image = red;
            picBox_green.Image = green;
            picBox_blue.Image = blue;
        }
    }
}
