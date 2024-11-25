using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mn_project15
{
    public partial class Form1 : Form
    {
        //tao bien gia tri nguong
        //double thresold;

        //tao chuoi chua link hinh
        string hinh = @"D:\hoc_xla\lena_color.png";

        //tao bien chua hinh
        Bitmap hinhgoc;

        public Form1()
        {
            InitializeComponent();

            //gan hinh
            hinhgoc = new Bitmap(hinh);

            //hien thi
            picBox_hinhgoc.Image = hinhgoc;
            picBox_nhandang.Image = NhanDangDuongBien(hinhgoc);
        }

        //tao ham nhan dang duong bien
        public Bitmap NhanDangDuongBien(Bitmap hinhgoc)
        {
            Bitmap EdgeDetection = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            int[,] sx =
            {
                {-1,-2,-1 },
                {0,0,0 },
                {1,2,1 }
            };
            int[,] sy =
            {
                {-1,0,1 },
                {-2,0,2 },
                {-1,0,1 }
            };
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    int GxR = 0;
                    int GyR = 0;
                    int GxG = 0;
                    int GyG = 0;
                    int GxB = 0;
                    int GyB = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            GxR = GxR + R * sx[i - (x - 1), j - (y - 1)];
                            GyR = GyR + R * sy[i - (x - 1), j - (y - 1)];
                            GxG = GxG + G * sx[i - (x - 1), j - (y - 1)];
                            GyG = GyG + G * sy[i - (x - 1), j - (y - 1)];
                            GxB = GxB + B * sx[i - (x - 1), j - (y - 1)];
                            GyB = GyB + B * sy[i - (x - 1), j - (y - 1)];

                        }

                    int gxx = Math.Abs(GxR) * Math.Abs(GxR) + Math.Abs(GxG) * Math.Abs(GxG) + Math.Abs(GxB) * Math.Abs(GxB);
                    int gyy = Math.Abs(GyR) * Math.Abs(GyR) + Math.Abs(GyG) * Math.Abs(GyG) + Math.Abs(GyB) * Math.Abs(GyB);
                    int gxy = (GxR * GyR) + (GxG * GyG) + (GxB * GyB);

                    double theta = 0.5 * Math.Atan2((2 * gxy), (gxx - gyy));

                    double F0 = Math.Sqrt(((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)) * 0.5);

                    if (F0 <= 130)
                        EdgeDetection.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        EdgeDetection.SetPixel(x, y, Color.FromArgb(255, 255, 255));

                }
            return EdgeDetection;
        }
    }
}
