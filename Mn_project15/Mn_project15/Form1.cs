using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                {-1, 0, 1},
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
                    //lay kenh mau tuong ung
                    byte R00 = pixel00.R;
                    byte G00 = pixel00.G;
                    byte B00 = pixel00.B;

                    Color pixel01 = hinhgoc.GetPixel(x    , y - 1);
                    byte R01 = pixel01.R;
                    byte G01 = pixel01.G;
                    byte B01 = pixel01.B;

                    Color pixel02 = hinhgoc.GetPixel(x + 1, y - 1);
                    byte R02 = pixel02.R;
                    byte G02 = pixel02.G;
                    byte B02 = pixel02.B;

                    Color pixel10 = hinhgoc.GetPixel(x - 1, y    );
                    byte R10 = pixel10.R;
                    byte G10 = pixel10.G;
                    byte B10 = pixel10.B;

                    Color pixel11 = hinhgoc.GetPixel(x    , y    );
                    byte R11 = pixel11.R;
                    byte G11 = pixel11.G;
                    byte B11 = pixel11.B;

                    Color pixel12 = hinhgoc.GetPixel(x + 1, y    );
                    byte R12 = pixel12.R;
                    byte G12 = pixel12.G;
                    byte B12 = pixel12.B;

                    Color pixel20 = hinhgoc.GetPixel(x - 1, y + 1);
                    byte R20 = pixel20.R;
                    byte G20 = pixel20.G;
                    byte B20 = pixel20.B;

                    Color pixel21 = hinhgoc.GetPixel(x    , y + 1);
                    byte R21 = pixel21.R;
                    byte G21 = pixel21.G;
                    byte B21 = pixel21.B;

                    Color pixel22 = hinhgoc.GetPixel(x + 1, y + 1);
                    byte R22 = pixel22.R;
                    byte G22 = pixel22.G;
                    byte B22 = pixel22.B;

                    //tinh vector tai diem P(x,y)
                    double gxR = (R00 * sobelx[0, 0] + R01 * sobelx[0, 1] + R02 * sobelx[0, 2] + R10 * sobelx[1, 0] + R11 * sobelx[1, 1] + R12 * sobelx[1, 2] + R20 * sobelx[2, 0] + R21 * sobelx[2, 1] + R22 * sobelx[2, 2]);
                    double gyR = (R00 * sobely[0, 0] + R01 * sobely[0, 1] + R02 * sobely[0, 2] + R10 * sobely[1, 0] + R11 * sobely[1, 1] + R12 * sobely[1, 2] + R20 * sobely[2, 0] + R21 * sobely[2, 1] + R22 * sobely[2, 2]);

                    //tinh vector tai diem P(x,y)
                    double gxG = (G00 * sobelx[0, 0] + G01 * sobelx[0, 1] + G02 * sobelx[0, 2] + G10 * sobelx[1, 0] + G11 * sobelx[1, 1] + G12 * sobelx[1, 2] + G20 * sobelx[2, 0] + G21 * sobelx[2, 1] + G22 * sobelx[2, 2]);
                    double gyG = (G00 * sobely[0, 0] + G01 * sobely[0, 1] + G02 * sobely[0, 2] + G10 * sobely[1, 0] + G11 * sobely[1, 1] + G12 * sobely[1, 2] + G20 * sobely[2, 0] + G21 * sobely[2, 1] + G22 * sobely[2, 2]);

                    //tinh vector tai diem P(x,y)
                    double gxB = (B00 * sobelx[0, 0] + B01 * sobelx[0, 1] + B02 * sobelx[0, 2] + B10 * sobelx[1, 0] + B11 * sobelx[1, 1] + B12 * sobelx[1, 2] + B20 * sobelx[2, 0] + B21 * sobelx[2, 1] + B22 * sobelx[2, 2]);
                    double gyB = (B00 * sobely[0, 0] + B01 * sobely[0, 1] + B02 * sobely[0, 2] + B10 * sobely[1, 0] + B11 * sobely[1, 1] + B12 * sobely[1, 2] + B20 * sobely[2, 0] + B21 * sobely[2, 1] + B22 * sobely[2, 2]);

                    //tinh tich cua vector
                    double gxx = gxR * gxR + gxG * gxG + gxB * gxB;
                    double gyy = gyR * gyR + gyG * gyG + gyB * gyB;
                    double gxy = gxR * gyR + gxG * gyG + gxB * gyB;

                    //tinh goc quay theta
                    double tu = 2 * gxy;
                    double mau = gxx - gxy;
                    double theta = (1 / 2) * (Math.Atan2(mau,tu));

                    //tinh gia tri ham so
                    double a = gxx + gyy;
                    double b = gxx - gyy;
                    double c = Math.Cos(2 * theta);
                    double d = 2 * Math.Abs(gxy) * Math.Sin(2 * theta);
                    double F = Math.Sqrt((1 / 2) * (a + b * c + d));

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
