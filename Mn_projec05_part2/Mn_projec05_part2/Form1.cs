using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using ZedGraph;

namespace Mn_projec05_part2
{
    public partial class lbl_Histogram_RGB : Form
    {
        public lbl_Histogram_RGB()
        {
            InitializeComponent();

            string hinh = @"D:\hoc_xla\bird_small.jpg";

            Bitmap hinhgoc = new Bitmap(hinh);

            //hien thi
            picBox_hinhgoc.Image = hinhgoc;

            //goi ham tinh toan histogram
            double[,] histogram = tinhHistogram(hinhgoc);

            //chuyen doi kieu du lieu
            List<PointPairList> points = ChuyendoiHistogram(histogram);

            //ve bieu do va hien thi
            zG_Histogram.GraphPane = vebieudoHistogram(points);
            zG_Histogram.Refresh();
        }

        //Tao ham tinh histogram cua anh RGB
        public double[,] tinhHistogram(Bitmap bmp)
        {
            //tao bien histogram co kieu dl la double
            //do gia tri cua tong co the la rat lon tuy theo kich thuoc cua anh
            double[,] histogram = new double[3, 256];

            //quet anh tu tren xuong duoi tu trai sang phai
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    //tao bien chua gia tri pixel 
                    Color pixel = bmp.GetPixel(x, y);

                    //tach diem anh ra gia tri 3 kenh R G B
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //gray co tri tu 0 den 256 gia tri cua gray chinh la dia chi cua histogram
                    //moi lan dia chi cua histogram lap lai gia tri tai dia chi do tang them 1
                    histogram[0, R]++;
                    histogram[1, G]++;
                    histogram[2, B]++;
                }
            }
            //tra ve gia tri histogram
            return histogram;
        }

        //chuyen doi diem histogram dung zedGraph
        List<PointPairList> ChuyendoiHistogram(double[,] histogram)
        {
            //tao mang  list<pointpairlist> la kieu du lieu cua zedgraph
            // ko can phai khai bao truoc so luong phan tu de ghi chuyen doi
            List<PointPairList> points = new List<PointPairList>();

            //tao pointpairlist luu gia tri chuyen doi cua kenh R
            PointPairList redpoints = new PointPairList();

            //tao pointpairlist luu gia tri chuyen doi cua kenh G
            PointPairList greenpoints = new PointPairList();

            //tao pointpairlist luu gia tri chuyen doi cua kenh B
            PointPairList bluepoints = new PointPairList();

            //quet mang dl histogram tu trai sang phai
            for (int i = 0; i < 256; i++)
            {
                //histogram[0, i] la so pixel R cung muc -> tuc la truc dung
                redpoints.Add(i, histogram[0, i]);

                //histogram[0, i] la so pixel G cung muc -> tuc la truc dung
                greenpoints.Add(i, histogram[1, i]);

                //histogram[0, i] la so pixel B cung muc -> tuc la truc dung
                bluepoints.Add(i, histogram[2, i]);
            }
            //add vao mang points
            points.Add(redpoints);
            points.Add(greenpoints);
            points.Add(bluepoints);

            //tra ve gia tri mang points
            return points;
        }

        //thiet lap 1 bieu do trong zedGraph
        public GraphPane vebieudoHistogram(List<PointPairList> histogram)
        {
            // tao bien doi tuong bieu do trong zedgraph
            GraphPane GP = new GraphPane();

            //dat ten cho biet do
            GP.Title.Text = @"Bieu do Histogram anh RGB";
            //tao khung chua bieu do
            GP.Rect = new Rectangle(0, 0, 700, 500);

            //thiet lap truc ngang
            GP.XAxis.Title.Text = @"Gia tri cua diem anh";
            GP.XAxis.Scale.Min = 0;
            GP.XAxis.Scale.Max = 255;
            GP.XAxis.Scale.MajorStep = 5;
            GP.XAxis.Scale.MinorStep = 1;

            //thiet lap truc doc
            GP.YAxis.Title.Text = @"So diem anh co cung muc";
            GP.YAxis.Scale.Min = 0;
            GP.YAxis.Scale.Max = 12500;
            GP.YAxis.Scale.MajorStep = 5;
            GP.YAxis.Scale.MinorStep = 1;

            //dung bieu do dang bar de bieu dien
            GP.AddBar("Histogram's Red", histogram[0], Color.Red);
            GP.AddBar("Histogram's Green", histogram[1], Color.Green);
            GP.AddBar("Histogram's Blue", histogram[2], Color.Blue);

            //tra ve gia tri gp
            return GP;

        }


    }
}
