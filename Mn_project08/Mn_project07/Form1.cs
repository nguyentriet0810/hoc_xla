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
        public List<Bitmap> RGBtoHSV(Bitmap RGBImage)
        {
            //tao list rong chua hinh can chuyen doi
            List<Bitmap> HSV = new List<Bitmap>();

            //tao bien chua hinh can chuyen doi
            Bitmap Hue = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Saturation = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Value = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap hsv = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap none = new Bitmap(RGBImage.Width, RGBImage.Height);

            //quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < RGBImage.Width; x++)
            {
                for (int y = 0; y < RGBImage.Height; y++)
                {
                    //lay gia tri diem anh
                    Color pixel = RGBImage.GetPixel(x, y);

                    //tach gia tri diem anh sang R G B
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //tinh cac gia  tri tong
                    double sum = R + G + B;

                    //tinh toan kenh mau theo cong thuc
                    //tinh gia tri kenh Hue
                    double t1 = ((R - G) + (R-B)) / 2;
                    double t2 = Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B));
                    double t4 = 0;
                    double theta = Math.Acos(t1 / t2);
                    
                    if (B <= G)
                    {
                        t4 = theta;
                    }
                    else if (B > G)
                    {
                        t4 = 2*Math.PI - theta;
                    }
                    double H = t4 * 360 / (2 * Math.PI);

                    //tinh gia tri kenh Saturation
                    double t3 = 1 - 3 * Math.Min(R, Math.Min(G, B)) / sum;
                    double S = t3 * 255;

                    //tinh gia tri kenh Intensity
                    double V = Math.Max(R, Math.Max(G, B));

                    //Gam gia tri diem anh va tung anh tuong ung
                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)S, (byte)S, (byte)S));
                    Value.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (byte)V));
                    hsv.SetPixel(x, y, Color.FromArgb((byte)H, (byte)S, (byte)V));
                    none.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }

            // add cac kenh hinh vao list rong tao o tren
            HSV.Add(Hue);
            HSV.Add(Saturation);
            HSV.Add(Value);
            HSV.Add(hsv);
            HSV.Add(none);

            //tra ve gia tri hsi
            return HSV;
        }

        private void b_creat_Click(object sender, EventArgs e)
        {
            List<Bitmap> hsv = RGBtoHSV(hinhgoc);
            picBox_H.Image = hsv[0];
            picBox_S.Image = hsv[1];
            picBox_I.Image = hsv[2];
            picBox_HSI.Image = hsv[3];
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            List<Bitmap> hsv = RGBtoHSV(hinhgoc);
            picBox_H.Image = hsv[4];
            picBox_S.Image = hsv[4];
            picBox_I.Image = hsv[4];
            picBox_HSI.Image = hsv[4];
        }
    }
}
