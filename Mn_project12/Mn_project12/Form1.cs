using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mn_project12
{
    public partial class Form1 : Form
    {
        //tao link den hinh
        string linkhinh = @"D:\hoc_xla\lena_color.png";

        //tao bien chua hinh
        Bitmap hinhgoc;

        public Form1()
        {
            InitializeComponent();

            hinhgoc = new Bitmap(linkhinh);

            //hien thi hinh
            picBox_hinhgoc.Image = hinhgoc;

        }

        //tao ham lam sac net hinh
        public Bitmap lamsacnethinh(Bitmap RGBImage)
        {
            //tao bien chua hinh moi co cung kich thuoc
            Bitmap newImage = new Bitmap(RGBImage.Width, RGBImage.Height);

            //quet anh tu trai sang phai
            for (int x = 1; x < RGBImage.Width - 1; x++)
            {
                
                //quet anh tu tren xuong duoi
                for (int y = 1; y < RGBImage.Height - 1; y++)
                {

                    //lay gia tri cac diem anh co trong cong thuc
                    Color pixel1 = RGBImage.GetPixel(x, y);
                    double R1 = pixel1.R;
                    double G1 = pixel1.G;
                    double B1 = pixel1.B;

                    Color pixel2 = RGBImage.GetPixel(x - 1, y);
                    double R2 = pixel2.R;
                    double G2 = pixel2.G;
                    double B2 = pixel2.B;

                    Color pixel3 = RGBImage.GetPixel(x + 1, y);
                    double R3 = pixel3.R;
                    double G3 = pixel3.G;
                    double B3 = pixel3.B;

                    Color pixel4 = RGBImage.GetPixel(x, y - 1);
                    double R4 = pixel4.R;
                    double G4 = pixel4.G;
                    double B4 = pixel4.B;

                    Color pixel5 = RGBImage.GetPixel(x, y + 1);
                    double R5 = pixel5.R;
                    double G5 = pixel5.G;
                    double B5 = pixel5.B;

                    //tinh toan theo cong thuc
                    double gR = R1 + (-1) * (R2 + R3 + R4 + R5 + (-4) * R1);
                    double gG = G1 + (-1) * (G2 + G3 + G4 + G5 + (-4) * G1);
                    double gB = B1 + (-1) * (B2 + B3 + B4 + B5 + (-4) * B1);

                    //gioi han gia tri ve khoang [0,255]
                    if (gR < 0) gR = 0;
                    else if (gR > 255) gR = 255;
                    if (gG < 0) gG = 0;
                    else if (gG > 255) gG = 255;
                    if (gB < 0) gB = 0;
                    else if (gB > 255) gB = 255;

                    //gan gia tri vao diem anh
                    newImage.SetPixel(x, y, Color.FromArgb((byte)gR, (byte)gG, (byte)gB));
                }
            }
            //tra ve gia tri cua hinh
            return newImage;
        }

        private void b_lamsacnet_Click(object sender, EventArgs e)
        {
            picBox_hinhlamsacnet.Image = lamsacnethinh(hinhgoc);
        }
    }
}
