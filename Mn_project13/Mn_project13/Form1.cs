using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mn_project13
{
    public partial class Form1 : Form
    {
        //tao chuoi chua duong dan cua hinh anh
        string hinh = @"D:\hoc_xla\lena_color.png";

        //tao bien luu hinh
        Bitmap hinhgoc;

        public Form1()
        {
            InitializeComponent();

            hinhgoc = new Bitmap(hinh);

            //hien thi hinh
            picBox_hinhgoc.Image = hinhgoc;

            //tinh vector trung binh mau
            List<double> Vector = TinhVectorTrungBinhMau(hinhgoc);

            picBox_hinhphandoan.Image = PhanDoanAnhMau(hinhgoc, Vector);
        }

        //tao ham tinh vector trung binh mau
        public List<double> TinhVectorTrungBinhMau(Bitmap hinhgoc)
        {
            //tao bien chua gia tri cua vector
            List<double> vector = new List<double>();

            //tao cac kenh vector
            double vectorR, vectorG, vectorB;

            //lay kich thuoc vung mau can quet
            double Size = (500 - 400) * (150 - 80);

            double Rs = 0, Gs = 0, Bs = 0;

            //quet vung mau tru trai sang phai tu tren xuong duoi
            for (int x = 80; x <= 150; x++)
            {
                for (int y = 400; y <= 500; y++)
                {

                    //lay pixel cua diem anh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //tinh toan gia tri câc kenh mau theo cong thuc
                    Rs = Rs + R;
                    Gs = Gs + G;
                    Bs = Bs + B;
                }
            }

            //tinh gia tri cua vector
            vectorR = Rs / Size;
            vectorG = Gs / Size;
            vectorB = Bs / Size;

            //gan cac gia tri kenh vector vao vector
            vector.Add(vectorR);
            vector.Add(vectorG);
            vector.Add(vectorB);

            //tra ve gia tri cua vector
            return vector;
        }

        //tao ham phan doan anh mau
        public Bitmap PhanDoanAnhMau(Bitmap hinhgoc, List<double> vector)
        {
            //tao bien chua anh da phan doan
            Bitmap newimage = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lay diem anh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //tinh toan cac gia tri kenh mau
                    double DR = ((R - vector[0]) * (R - vector[0]));
                    double DG = ((G - vector[1]) * (G - vector[1]));
                    double DB = ((B - vector[2]) * (B - vector[2]));

                    //tinh toan gia tri Eu-clidean distance
                    double D = Math.Sqrt(DR + DG + DB);

                    //so sanh voi gia tri nguong
                    if (D <= 45)
                    {
                        R = 255;
                        G = 255;
                        B = 255;
                    }

                    //gan gia tri mau vao diem anh
                    newimage.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            //tra ve gia tri anh
            return newimage;
        }
    }
}
