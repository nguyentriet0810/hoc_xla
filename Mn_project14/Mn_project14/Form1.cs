using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mn_project14
{
    public partial class Form1 : Form
    {
        //tao bien toan cuc
        double threshold = 130;
        int option = 0; // 0 usesobel; 1 use prewitt; 2 use roberts
        //tao chuoi chua hinh
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
                {-2, 0, 2},
                {-1, 0, 1}
            };

        //tao mat na Prewitt

        double[,] prewittx = new double[3, 3]
            {
                {-1,-1,-1 },
                { 0, 0, 0 },
                { 1, 1, 1}
            };

        double[,] prewitty = new double[3, 3]
            {
                {-1, 0, 1 },
                {-1, 0, 1 },
                {-1, 0, 1 }
            };

        //khai bao mat na Roberts
        double[,] robertsx = new double[2, 2]
            {
                {-1, 0 },
                { 0, 1 }
            };
        double[,] robertsy = new double[2, 2]
            {
                { 0,-1 },
                { 1, 0 }
            };

        public Form1()
        {
            InitializeComponent();

            //gan anh vao
            hinhgoc = new Bitmap(hinh);

            //hien thi hinh
            picBoc_hinhgoc.Image = hinhgoc;

            Bitmap Gray = RGBtoGrayscale(hinhgoc);

            picBox_duongbien.Image = NhanDangDuongBien(Gray, option, threshold);

        }
        public Bitmap RGBtoGrayscale(Bitmap hinhgoc)
        {
            //tao bien chua hinh
            Bitmap Grayscale = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {

                    //lay diem anh
                    Color pixel = hinhgoc.GetPixel(x, y);

                    //gan vao kenh mau tuong ung
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //tinh theo cong thuc average
                    byte gray = (byte)((R + G + B) / 3);

                    //gan diem anh vao anh
                    Grayscale.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            //tra ve anh muc xam 
            return Grayscale;
        }

        //tao ham nhan dang duong bien
        public Bitmap NhanDangDuongBien(Bitmap Grayscale, int option, double threshold)
        {
            //tao bien chhua anh
            Bitmap NewImage = new Bitmap(Grayscale.Width, Grayscale.Height);

            //quet anh tru trai sang phai tu tren xung duoi
            for (int x = 1; x < (Grayscale.Width - 1); x++)
            {
                for (int y = 1; y < (Grayscale.Height -1); y++)
                {

                    //lay cac diem anh co lien quan
                    Color pixel00 = Grayscale.GetPixel(x - 1, y - 1);
                    Color pixel01 = Grayscale.GetPixel(x    , y - 1);
                    Color pixel02 = Grayscale.GetPixel(x + 1, y - 1);
                    Color pixel10 = Grayscale.GetPixel(x - 1, y    );
                    Color pixel11 = Grayscale.GetPixel(x    , y    );
                    Color pixel12 = Grayscale.GetPixel(x + 1, y    );
                    Color pixel20 = Grayscale.GetPixel(x - 1, y + 1);
                    Color pixel21 = Grayscale.GetPixel(x    , y + 1);
                    Color pixel22 = Grayscale.GetPixel(x + 1, y + 1);

                    //lay kenh mau
                    byte R00 = pixel00.R;
                    byte R01 = pixel01.R;
                    byte R02 = pixel02.R;
                    byte R10 = pixel10.R;
                    byte R11 = pixel11.R;
                    byte R12 = pixel12.R;
                    byte R20 = pixel20.R;
                    byte R21 = pixel21.R;
                    byte R22 = pixel22.R;

                    double gx = 0;
                    double gy = 0;

                    if (option == 0)
                    {
                        //tinh vector tai diem P(x,y)
                        gx = (R00 * sobelx[0, 0] + R01 * sobelx[0, 1] + R02 * sobelx[0, 2] + R10 * sobelx[1, 0] + R11 * sobelx[1, 1] + R12 * sobelx[1, 2] + R20 * sobelx[2, 0] + R21 * sobelx[2, 1] + R22 * sobelx[2, 2]);
                        gy = (R00 * sobely[0, 0] + R01 * sobely[0, 1] + R02 * sobely[0, 2] + R10 * sobely[1, 0] + R11 * sobely[1, 1] + R12 * sobely[1, 2] + R20 * sobely[2, 0] + R21 * sobely[2, 1] + R22 * sobely[2, 2]);
                    }
                    else if (option == 1)
                    {
                        gx = (R00 * prewittx[0, 0] + R01 * prewittx[0, 1] + R02 * prewittx[0, 2] + R10 * prewittx[1, 0] + R11 * prewittx[1, 1] + R12 * prewittx[1, 2] + R20 * prewittx[2, 0] + R21 * prewittx[2, 1] + R22 * prewittx[2, 2]);
                        gy = (R00 * prewitty[0, 0] + R01 * prewitty[0, 1] + R02 * prewitty[0, 2] + R10 * prewitty[1, 0] + R11 * prewitty[1, 1] + R12 * prewitty[1, 2] + R20 * prewitty[2, 0] + R21 * prewitty[2, 1] + R22 * prewitty[2, 2]);

                    }
                    else if (option == 2)
                    {
                        gx = (R11 * robertsx[0, 0] + R12 * robertsx[0, 1] + R21 * robertsx[1, 0] + R22 * robertsx[1, 1]);
                        gy = (R11 * robertsy[0, 0] + R12 * robertsy[0, 1] + R21 * robertsy[1, 0] + R22 * robertsy[1, 1]);
                    }
                    //tinh gia tri do dai vector ki hieu la M
                    double M = Math.Abs(gx) + Math.Abs(gy);

                    //so sanh voi gia tri nguong
                    if(M <= threshold)
                    {
                        M = 0;
                    }
                    else
                    {
                        M = 255;
                    };

                    //gan gia tri vao diem anh
                    NewImage.SetPixel(x, y, Color.FromArgb((byte)M, (byte)M, (byte)M));
                }
            }
            //tra ve gia tri anh
            return NewImage;
        }

        private void giatrithreshold_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
