using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mn_project11
{
    public partial class Form1 : Form
    {
        //tao link hinh
        string linkhinh = @"D:\hoc_xla\lena_color.png";

        //tao bien chua hinh
        Bitmap hinhgoc;

        public Form1()
        {
            InitializeComponent();

            //tao bien chua hinh
            hinhgoc = new Bitmap(linkhinh);

            //hien thi hinh anah
            picBox_hinhgoc.Image = hinhgoc;
        }

        //tao ham tinh hinh lam muot mask 3x3
        public Bitmap ColorImageSmoothingMask3x3(Bitmap RGBImange)
        {
            //tao bien chua hinh
            Bitmap SmoothedImage = new Bitmap(RGBImange.Width, RGBImange.Height);

            //quet anh  tu trai sang phai tu tren xuong duoi
            //tuy nhien voi mask 3x3 ta co 1 pixel can lam muot va 8 pixel xung quanh 
            //nen khi quwt ta ko can quet cac hang va cot ngoai cung vi ko du so o
            for (int x = 1; x < RGBImange.Width - 1; x++)
            {
                for (int y = 1; y < RGBImange.Height - 1; y++)
                {

                    //khai bao cac bien de cong du lieu
                    int Rs = 0, Gs = 0, Bs = 0;

                    //quet cac diem trong mat na tu trai sang phai [x-1,x+1] tu tren xuong duoi [y-1,y+1]
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            //lay gia tri cua diem anh
                            Color pixel = RGBImange.GetPixel(i, j);
                            
                            //gan gtri diem anh vao cac bien roi
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            //tinh tong cac gia tri trong 1 kenh
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    }
                    //tinh kich thuoc mat na
                    int K = 3 * 3;

                    //tinh trung binh cac kenh anh theo cong thuc
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set gia tri diem anh da lam muot va anh
                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            }

            //tra ve gia tri hinh
            return SmoothedImage;
        }

        //tao ham tinh hinh lam muot mask 5x5
        public Bitmap ColorImageSmoothingMask5x5(Bitmap RGBImange)
        {
            //tao bien chua hinh
            Bitmap SmoothedImage = new Bitmap(RGBImange.Width, RGBImange.Height);

            //quet anh  tu trai sang phai tu tren xuong duoi
            //tuy nhien voi mask 3x3 ta co 1 pixel can lam muot va 8 pixel xung quanh 
            //nen khi quwt ta ko can quet cac hang va cot ngoai cung vi ko du so o
            for (int x = 2; x < RGBImange.Width - 2; x++)
            {
                for (int y = 2; y < RGBImange.Height - 2; y++)
                {

                    //khai bao cac bien de cong du lieu
                    int Rs = 0;
                    int Gs = 0;
                    int Bs = 0;

                    //quet cac diem trong mat na tu trai sang phai [x-1,x+1] tu tren xuong duoi [y-1,y+1]
                    for (int i = x - 2; i <= x + 2; i++)
                    {
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            //lay gia tri cua diem anh
                            Color pixel = RGBImange.GetPixel(i, j);

                            //gan gtri diem anh vao cac bien roi
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            //tinh tong cac gia tri trong 1 kenh
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    }
                    //tinh kich thuoc mat na
                    byte K = 5 * 5;

                    //tinh trung binh cac kenh anh theo cong thuc
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set gia tri diem anh da lam muot va anh
                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            }

            //tra ve gia tri hinh
            return SmoothedImage;
        }

        //tao ham tinh hinh lam muot mask 7x7
        public Bitmap ColorImageSmoothingMask7x7(Bitmap RGBImange)
        {
            //tao bien chua hinh
            Bitmap SmoothedImage = new Bitmap(RGBImange.Width, RGBImange.Height);

            //quet anh  tu trai sang phai tu tren xuong duoi
            //tuy nhien voi mask 3x3 ta co 1 pixel can lam muot va 8 pixel xung quanh 
            //nen khi quwt ta ko can quet cac hang va cot ngoai cung vi ko du so o
            for (int x = 3; x < RGBImange.Width - 3; x++)
            {
                for (int y = 3; y < RGBImange.Height - 3; y++)
                {

                    //khai bao cac bien de cong du lieu
                    int Rs = 0;
                    int Gs = 0;
                    int Bs = 0;

                    //quet cac diem trong mat na tu trai sang phai [x-3,x+3] tu tren xuong duoi [y-3,y+3]
                    for (int i = x - 3; i <= x + 3; i++)
                    {
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            //lay gia tri cua diem anh
                            Color pixel = RGBImange.GetPixel(i, j);

                            //gan gtri diem anh vao cac bien roi
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            //tinh tong cac gia tri trong 1 kenh
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    }
                    //tinh kich thuoc mat na
                    byte K = 7 * 7;

                    //tinh trung binh cac kenh anh theo cong thuc
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set gia tri diem anh da lam muot va anh
                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            }

            //tra ve gia tri hinh
            return SmoothedImage;
        }

        //tao ham tinh hinh lam muot mask 9x9
        public Bitmap ColorImageSmoothingMask9x9(Bitmap RGBImange)
        {
            //tao bien chua hinh
            Bitmap SmoothedImage = new Bitmap(RGBImange.Width, RGBImange.Height);

            //quet anh  tu trai sang phai tu tren xuong duoi
            //tuy nhien voi mask 3x3 ta co 1 pixel can lam muot va 8 pixel xung quanh 
            //nen khi quwt ta ko can quet cac hang va cot ngoai cung vi ko du so o
            for (int x = 4; x < RGBImange.Width - 4; x++)
            {
                for (int y = 4; y < RGBImange.Height - 4; y++)
                {

                    //khai bao cac bien de cong du lieu
                    int Rs = 0;
                    int Gs = 0;
                    int Bs = 0;

                    //quet cac diem trong mat na tu trai sang phai [x-1,x+1] tu tren xuong duoi [y-1,y+1]
                    for (int i = x - 4; i <= x + 4; i++)
                    {
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            //lay gia tri cua diem anh
                            Color pixel = RGBImange.GetPixel(i, j);

                            //gan gtri diem anh vao cac bien roi
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            //tinh tong cac gia tri trong 1 kenh
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    }
                    //tinh kich thuoc mat na
                    byte K = 9 * 9;

                    //tinh trung binh cac kenh anh theo cong thuc
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set gia tri diem anh da lam muot va anh
                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            }

            //tra ve gia tri hinh
            return SmoothedImage;
        }

        private void b_7x7_Click(object sender, EventArgs e)
        {
            picBox_mask7x7.Image = ColorImageSmoothingMask7x7(hinhgoc);
        }

        private void b_9x9_Click(object sender, EventArgs e)
        {
            picBox_mask9x9.Image = ColorImageSmoothingMask9x9(hinhgoc);
        }

        private void b_3x3_Click(object sender, EventArgs e)
        {
            picBox_mask3x3.Image = ColorImageSmoothingMask3x3(hinhgoc);
        }

        private void b_5x5_Click(object sender, EventArgs e)
        {
            picBox_mask5x5.Image = ColorImageSmoothingMask5x5(hinhgoc);
        }
    }
}
