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

        //bien goc quay
        double theta;
        double F;

        //tao list sobel
        double[,] sobelx = new double[3, 3]
            {
                {-1,-2,-1},
                { 0, 0, 0},
                { 1, 2, 1}
            };
        double[,] sobely = new double[3, 3]
            {
                {-1, 0, 1},
                {-2, 0, 2},
                {-1, 0, 1}
            };

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
            //tao bien chua anh
            Bitmap NewImage = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 1; x < (hinhgoc.Width - 1); x++)
            {
                for (int y = 1; y < (hinhgoc.Height - 1); y++)
                {
                    //lay cac diem anh co lien quan
                    Color pixel00 = hinhgoc.GetPixel(x - 1, y - 1);
                    Color pixel01 = hinhgoc.GetPixel(x    , y - 1);
                    Color pixel02 = hinhgoc.GetPixel(x + 1, y - 1);
                    Color pixel10 = hinhgoc.GetPixel(x - 1, y    );
                    Color pixel11 = hinhgoc.GetPixel(x    , y    );
                    Color pixel12 = hinhgoc.GetPixel(x + 1, y    );
                    Color pixel20 = hinhgoc.GetPixel(x - 1, y + 1);
                    Color pixel21 = hinhgoc.GetPixel(x    , y + 1);
                    Color pixel22 = hinhgoc.GetPixel(x + 1, y + 1);

                    //tinh vector tai diem P(x,y)
                    double gxR = (pixel00.R * sobelx[0, 0] + pixel01.R * sobelx[0, 1] + pixel02.R * sobelx[0, 2] + pixel10.R * sobelx[1, 0] + pixel11.R * sobelx[1, 1] + pixel12.R * sobelx[1, 2] + pixel20.R * sobelx[2, 0] + pixel21.R * sobelx[2, 1] + pixel22.R * sobelx[2, 2]);
                    double gyR = (pixel00.R * sobely[0, 0] + pixel01.R * sobely[0, 1] + pixel02.R * sobely[0, 2] + pixel10.R * sobely[1, 0] + pixel11.R * sobely[1, 1] + pixel12.R * sobely[1, 2] + pixel20.R * sobely[2, 0] + pixel21.R * sobely[2, 1] + pixel22.R * sobely[2, 2]);

                    //tinh vector tai diem P(x,y)
                    double gxG = (pixel00.G * sobelx[0, 0] + pixel01.G * sobelx[0, 1] + pixel02.G * sobelx[0, 2] + pixel10.G * sobelx[1, 0] + pixel11.G * sobelx[1, 1] + pixel12.G * sobelx[1, 2] + pixel20.G * sobelx[2, 0] + pixel21.G * sobelx[2, 1] + pixel22.G * sobelx[2, 2]);
                    double gyG = (pixel00.G * sobely[0, 0] + pixel01.G * sobely[0, 1] + pixel02.G * sobely[0, 2] + pixel10.G * sobely[1, 0] + pixel11.G * sobely[1, 1] + pixel12.G * sobely[1, 2] + pixel20.G * sobely[2, 0] + pixel21.G * sobely[2, 1] + pixel22.G * sobely[2, 2]);

                    //tinh vector tai diem P(x,y)
                    double gxB = (pixel00.B * sobelx[0, 0] + pixel01.B * sobelx[0, 1] + pixel02.B * sobelx[0, 2] + pixel10.B * sobelx[1, 0] + pixel11.B * sobelx[1, 1] + pixel12.B * sobelx[1, 2] + pixel20.B * sobelx[2, 0] + pixel21.B * sobelx[2, 1] + pixel22.B * sobelx[2, 2]);
                    double gyB = (pixel00.B * sobely[0, 0] + pixel01.B * sobely[0, 1] + pixel02.B * sobely[0, 2] + pixel10.B * sobely[1, 0] + pixel11.B * sobely[1, 1] + pixel12.B * sobely[1, 2] + pixel20.B * sobely[2, 0] + pixel21.B * sobely[2, 1] + pixel22.B * sobely[2, 2]);

                    //tinh tich cua vector
                    double gxx = gxR * gxR + gxG * gxG + gxB * gxB;
                    double gyy = gyR * gyR + gyG * gyG + gyB * gyB;
                    double gxy = Math.Abs(gxR * gyR + gxG * gyG + gxB * gyB);

                    //tinh goc quay theta
                    double tu = 2 * gxy;
                    double mau = gxx - gyy;
                    if (mau == 0)
                    {
                        theta = Math.PI / 2;
                    }
                    else
                    {
                        theta = (1 / 2) * (Math.Atan2(mau, tu));
                    }

                    //tinh gia tri ham so
                    double a = gxx + gyy;
                    double b = gxx - gyy;
                    double c = Math.Cos((2 * theta));
                    double d = 2 * gxy * Math.Sin((2 * theta));
                    F = Math.Sqrt((1 / 2) * (a + (b * c) + d));

                    if (F <= 130)
                    {
                        F = 0;
                    }
                    else
                    {
                        F = 255;
                    }

                    NewImage.SetPixel(x, y, Color.FromArgb((byte)F, (byte)F, (byte)F));
                }
            }
            //tra ve gia tri anh
            return NewImage;
        }
    }
}
