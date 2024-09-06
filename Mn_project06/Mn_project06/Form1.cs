using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mn_project06
{
    public partial class Form1 : Form
    {
        // tao duong dan den hinh
        string linkhinh = @"D:\hoc_xla\lena_color.png";

        // tao bien chua hinh
        Bitmap hinhgoc;

        public Form1()
        {
            InitializeComponent();

            hinhgoc = new Bitmap(linkhinh);

            // hien thi hinh anh
            picBox_hinhgoc.Image = hinhgoc;
        }

        // tao ham tach anh RGB sang R, G, B
        public List<Bitmap> RGBtoCMYK(Bitmap RGBImage)
        {
            //tao list<bitmap> la list rong de chua 4 kenh hinh
            List<Bitmap> CMYK = new List<Bitmap>();

            //tao doi tuong chua tung hinh
            Bitmap Cyan = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Magenta = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Yellow = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap Black = new Bitmap(RGBImage.Width, RGBImage.Height);
            Bitmap None = new Bitmap(RGBImage.Width, RGBImage.Height);

            //quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < RGBImage.Width; x++)
            {
                for (int y = 0; y < RGBImage.Height; y++)
                {
                    //tao bien chua gia tri pixel 
                    Color pixel = RGBImage.GetPixel(x, y);

                    //tach diem anh ra gia tri 3 kenh R G B
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //so sanh va lay gia tri mau nho nhat
                    byte black = (byte)(Math.Min(R, Math.Min(G, B)));

                    //tinh toan gia tri mau Cyan
                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));

                    //tinh toan gia tri mau Magenta
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));

                    //tinh toan gia tri mau Yellow
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));

                    //tinh toan gia tri mau Black
                    Black.SetPixel(x, y, Color.FromArgb(black, black, black));

                    //set anh rong
                    None.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            // add cac kenh hinh vao list vua tao o tren
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);
            CMYK.Add(None);

            //Tra ve gia tri cua list
            return CMYK;
        }

        // tao event nhan nut moi creat anh ra
        private void b_creat_Click(object sender, EventArgs e)
        {
            //hinhgoc = new Bitmap(linkhinh);

            //hien thi hinh anh
            List<Bitmap> CMYK = RGBtoCMYK(hinhgoc);
            picBox_C.Image = CMYK[0];
            picBox_M.Image = CMYK[1];
            picBox_Y.Image = CMYK[2];
            picBox_K.Image = CMYK[3];
        }

        //tao vevent nhat nut thi xoa anh creat vua roi
        private void b_cancel_Click(object sender, EventArgs e)
        {
            //hinhgoc = new Bitmap(linkhinh);

            //hien thi hinh anh
            List<Bitmap> CMYK = RGBtoCMYK(hinhgoc);
            picBox_C.Image = CMYK[4];
            picBox_M.Image = CMYK[4];
            picBox_Y.Image = CMYK[4];
            picBox_K.Image = CMYK[4];
        }
    }
}
