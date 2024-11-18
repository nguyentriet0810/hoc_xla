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

            //tao bien chua anh
            hinhgoc = new Bitmap(linkhinh);

            // gan gia tri cho hinh rong
            //hien thi hinh anh
            picBox_hinhgoc.Image = hinhgoc;

        }

        //tao ham taach anh RGB va chuyen sang HSI
        public List<Bitmap> RGBtoXYZ(Bitmap RGBImage)
        {
            //tao list rong chua hinh can chuyen doi
            List<Bitmap> XYZ = new List<Bitmap>();

            //tao bien chua hinh can chuyen doi
            Bitmap X = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Y = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Z = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap xyz = new Bitmap(RGBImage.Width, RGBImage.Height);
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
                    byte x = (byte)(0.4124564 * R + 0.3575761 * G + 0.1804375 * B);
                    byte y = (byte)(0.2126729 * R + 0.7151522 * G + 0.0721750 * B);
                    byte z = (byte)(0.0193339 * R + 0.1191920 * G + 0.9503041 * B);

                    //Gam gia tri diem anh va tung anh tuong ung
                    X.SetPixel(a, b, Color.FromArgb(x, x, x));
                    Y.SetPixel(a, b, Color.FromArgb(y, y, y));
                    Z.SetPixel(a, b, Color.FromArgb(z, z, z));
                    xyz.SetPixel(a, b, Color.FromArgb(x, y, z));
                    none.SetPixel(a, b, Color.FromArgb(255, 255, 255));
                }
            }

            // add cac kenh hinh vao list rong tao o tren
            XYZ.Add(X);
            XYZ.Add(Y);
            XYZ.Add(Z);
            XYZ.Add(xyz);
            XYZ.Add(none);

            //tra ve gia tri hsi
            return XYZ;
        }

        private void b_creat_Click(object sender, EventArgs e)
        {
            List<Bitmap> xyz = RGBtoXYZ(hinhgoc);
            picBox_X.Image = xyz[0];
            picBox_Y.Image = xyz[1];
            picBox_Z.Image = xyz[2];
            picBox_XYZ.Image = xyz[3];
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            List<Bitmap> xyz = RGBtoXYZ(hinhgoc);
            picBox_X.Image = xyz[4];
            picBox_Y.Image = xyz[4];
            picBox_Z.Image = xyz[4];
            picBox_XYZ.Image = xyz[4];
        }
    }
}
