using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mn_project03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tao chuoi chua link hinh
            String linkhinh = @"F:\hoc_xla\lena_color.png";
            // tao doi tuong bitmap la hinh can hien thi
            Bitmap hinhgoc = new Bitmap(linkhinh);
            //Hien thi hinh
            pictureBox_anhgoc.Image = hinhgoc;
            // hien thi hinh gray lightness 
            pictureBox_Lightness.Image = RGBtoGrayscaleUseLightness(hinhgoc);
            // hien thi hinh gray Average 
            pictureBox_GrayAverage.Image = RGBtoGrayscaleUseAverage(hinhgoc);
            // hien thi hinh gray luminance
            pictureBox_Luminance.Image = RGBtoGrayscaleUseLuminance(hinhgoc);
         }

        //Ham xu ly anh RGB sang anh Gray dung phuong phap Lightness
        public Bitmap RGBtoGrayscaleUseLightness(Bitmap hinhgoc)
        {
            Bitmap GrayLightness = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            // quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // lay diem anh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Tinh gia tri gray lightness
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2);

                    // gan gia tri vao diem anh
                    GrayLightness.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return GrayLightness;

        }
        //Ham xu ly anh RGB sang anh Gray dung phuong phap Average
        public Bitmap RGBtoGrayscaleUseAverage(Bitmap hinhgoc)
        {
            Bitmap GrayAverage = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            // quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // lay diem anh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Tinh gia tri gray lightness
                    byte gray = (byte)((R + G + B) / 3);

                    // gan gia tri vao diem anh
                    GrayAverage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return GrayAverage;

        }
        //Ham xu ly anh RGB sang anh Gray dung phuong phap Luminance
        public Bitmap RGBtoGrayscaleUseLuminance(Bitmap hinhgoc)
        {
            Bitmap GrayLuminance = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            // quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // lay diem anh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Tinh gia tri gray lightness
                    byte gray = (byte)((R*0.2126 + G*0.7152 + B*0.722) / 3);

                    // gan gia tri vao diem anh
                    GrayLuminance.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return GrayLuminance;

        }
        private void pictureBox_anhgoc_Click(object sender, EventArgs e)
        {

        }
    }
}
