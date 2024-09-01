using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// khhai bao thu vien
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Mn_project04
{
    public partial class Form1 : Form
    {
        //tao bien toan cuc
        byte threshold;

        //Tao bien bitmap luu hinh anh
        Bitmap hinhgoc;

        public Form1()
        {
            InitializeComponent();

            //Gan hinh goc  = link anh
            hinhgoc = new Bitmap(@"F:\hoc_xla\lena_color.png");

            // hien thi anh
            picBox_anh_goc.Image = hinhgoc; 
        }
        // Tao ham chuyen anh tu RGB sang Binary
        public Bitmap RGBtoBinary(Bitmap hinhgoc, byte a)
        {
            //Tao bien moi chua hinh binary
            Bitmap picBinary = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            // quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //khai bao bien pixel va lay gia tri pixel
                    Color pixel = hinhgoc.GetPixel(x, y);

                    // khai bao bien R G B va gian gia tri tuong ung
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //tinh toan gia tri binary
                    byte Binary = (byte)((R + G + B)/3);

                    //So sanh voi gia tri threshold va gan lai gia tri cho binary
                    if (Binary < a)
                    {
                        Binary = 0;
                    }
                    else
                    {
                        Binary = 255;
                    }

                    //Gan gia tri vao hinh
                    picBinary.SetPixel(x, y, Color.FromArgb(Binary, Binary, Binary));
                }
            }
            return picBinary;
        }

        private void picBox_Binary_Click(object sender, EventArgs e)
        {

        }

        private void giatrithreshold_ValueChanged(object sender, EventArgs e)
        {
            //Gan ggia tri threshold = gitr vSrollBar
            threshold = (byte)giatrithreshold.Value;

            //hine thi gia tri threshold
            lblthreshold.Text = threshold.ToString();

            // hien thhi anh
            picBox_Binary.Image = RGBtoBinary(hinhgoc, threshold);
        }
    }
}
