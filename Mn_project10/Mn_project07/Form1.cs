using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mn_project07
{
    public partial class Form1 : Form
    {
        //tao link den hinh anh
        string linkhinh = @"D:\hoc_xla\lena_color.png";

        //tao bien chua anh
        Bitmap hinhgoc;

        public Form1()
        {
            InitializeComponent();

            //tao link den hinh anh
            string linkhinh = @"D:\hoc_xla\lena_color.png";

            //tao bien chua anh
            hinhgoc = new Bitmap(linkhinh);

            // gan gia tri cho hinh rong
            //hien thi hinh anh
            picBox_hinhgoc.Image = hinhgoc;

        }

        //tao ham taach anh RGB va chuyen sang HSI
        public List<Bitmap> RGBtoYCbCr(Bitmap RGBImage)
        {
            //tao list rong chua hinh can chuyen doi
            List<Bitmap> YCbCr = new List<Bitmap>();

            //tao bien chua hinh can chuyen doi
            Bitmap Y = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Cb = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Cr = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap ycbcr = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap none = new Bitmap(RGBImage.Width, RGBImage.Height);

            //quet anh tu trai sang phai tu tren xuong duoi
            for (int a = 0; a < RGBImage.Width; a++)
            {
                for (int b = 0; b < RGBImage.Height; b++)
                {
                    //lay gia tri diem anh
                    Color pixel = RGBImage.GetPixel(a, b);

                    //tach gia tri diem anh sang R G B
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //tinh toan gia tri theo cong thuc
                    byte y = (byte)(16 + (65.738 * R + 159.057 * G + 25.064 * B) / 256);
                    byte cb = (byte)(128 - (37.945 * R + 74.494 * G - 112.439 * B) / 256);
                    byte cr = (byte)(128 + (112.439 * R - 94.154 * G - 18.285 * B) / 256);

                    //Gam gia tri diem anh va tung anh tuong ung
                    Y.SetPixel(a, b, Color.FromArgb(y, y, y));
                    Cb.SetPixel(a, b, Color.FromArgb(cb, cb, cb));
                    Cr.SetPixel(a, b, Color.FromArgb(cr, cr, cr));
                    ycbcr.SetPixel(a, b, Color.FromArgb(y, cb, cr));
                    none.SetPixel(a, b, Color.FromArgb(255, 255, 255));
                }
            }

            // add cac kenh hinh vao list rong tao o tren
            YCbCr.Add(Y);
            YCbCr.Add(Cb);
            YCbCr.Add(Cr);
            YCbCr.Add(ycbcr);
            YCbCr.Add(none);

            //tra ve gia tri hsi
            return YCbCr;
        }

        private void b_creat_Click(object sender, EventArgs e)
        {
            List<Bitmap> ycbcr = RGBtoYCbCr(hinhgoc);
            picBox_Y.Image = ycbcr[0];
            picBox_Cb.Image = ycbcr[1];
            picBox_Cr.Image = ycbcr[2];
            picBox_YCbCr.Image = ycbcr[3];
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            List<Bitmap> ycbcr = RGBtoYCbCr(hinhgoc);
            picBox_Y.Image = ycbcr[4];
            picBox_Cb.Image = ycbcr[4];
            picBox_Cr.Image = ycbcr[4];
            picBox_YCbCr.Image = ycbcr[4];
        }
    }
}
