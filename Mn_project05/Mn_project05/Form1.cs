using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Mn_project05
{
    public partial class Histogram_Grayscale : Form
    {
        public Histogram_Grayscale()
        {
            InitializeComponent();

            // tao chuoi chua link hinh
            string linkhinh = @"F:\hoc_xla\bird_small.jpg";

            //tao bien chua hinh
            Bitmap hinhgoc = new Bitmap(linkhinh);
            Bitmap hinhmucxam = RGBtoGrayscal_Use_Average(hinhgoc);

            //hien thi hinh
            picBox_hinhgoc.Image = hinhgoc;
            picBox_Grayscale_Average.Image = hinhmucxam;

            //goi ham tinh toan histogram
            double[] histogram = tinhHistogram(hinhmucxam);

            //chuyen doi kieu du lieu
            PointPairList points = ChuyendoiHistogram(histogram);

            //ve bieu do va hien thi
            zG_Histogram.GraphPane = vebieudoHistogram(points);
            zG_Histogram.Refresh();
        }

        //tao ham tach anh rgb sang grayscale dung pp average
        public Bitmap RGBtoGrayscal_Use_Average(Bitmap hinhgoc)
        {
            // tao bien bitmap chua anh muc xam co chieu dai rong = hinhgoc
            Bitmap GrayAverage = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quet anh tu trai sang phai tu tren xuong duoi
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //tao bien chua gia tri pixel 
                    Color pixel = hinhgoc.GetPixel(x, y);

                    //tach R G B
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // tinh muc xam dung pp average
                    byte gray = (byte)((R + G + B) / 3);

                    //gan gia tri diem anh
                    GrayAverage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            //tra ve gia tri anh muc xam
            return GrayAverage;
        }
        //Tao ham tinh histogram cua anh muc xam
        public double[] tinhHistogram(Bitmap hinhmucxam)
        {
            //tao bien histogram co kieu dl la double
            //do gia tri cua tong co the la rat lon tuy theo kich thuoc cua anh
            double[] histogram = new double[256];

            //quet anh tu tren xuong duoi tu trai sang phai
            for (int x = 0; x < hinhmucxam.Width; x++)
            {
                for (int y = 0; y < hinhmucxam.Height; y++)
                {
                    //tao bien chua gia tri pixel 
                    Color pixel = hinhmucxam.GetPixel(x, y);

                    //tach diem anh trong anh muc xam gia tri 3 kenh R G B la nhu nhau
                    byte gray = pixel.R;

                    //gray co tri tu 0 den 256 gia tri cua gray chinh la dia chi cua histogram
                    //moi lan dia chi cua histogram lap lai gia tri tai dia chi do tang them 1
                    histogram[gray]++;
                }
            }
            //tra ve gia tri histogram
            return histogram;
        }

        //chuyen doi diem histogram dung zedGraph
        PointPairList ChuyendoiHistogram(double[] histogram)
        {
            //tao bien pointpairlist la kieu du lieu cua zedgraph de ve bieu do
            PointPairList points = new PointPairList();

            //quet mang dl histogram tu trai sang phai
            for (int i = 0; i < histogram.Length; i++)
            {
                //histogram[i] la so pixel cung muc xam tuc la truc dung
                points.Add(i, histogram[i]);
            }
            return points;
        }

        //thiet lap 1 bieu do trong zedGraph
        public GraphPane vebieudoHistogram(PointPairList histogram)
        {
            // tao bien doi tuong bieu do trong zedgraph
            GraphPane GP = new GraphPane();

            //dat ten cho biet do
            GP.Title.Text = @"Bieu do Histogram anh muc xam";
            //tao khung chua bieu do
            GP.Rect = new Rectangle(0, 0, 700, 500);

            //thiet lap truc ngang
            GP.XAxis.Title.Text = @"Gia tri muc xam cua diem anh";
            GP.XAxis.Scale.Min = 0;
            GP.XAxis.Scale.Max = 255;
            GP.XAxis.Scale.MajorStep = 5;
            GP.XAxis.Scale.MinorStep = 1;

            //thiet lap truc doc
            GP.YAxis.Title.Text = @"So diem anh co cung muc xam";
            GP.YAxis.Scale.Min = 0;
            GP.YAxis.Scale.Max = 15000;
            GP.YAxis.Scale.MajorStep = 5;
            GP.YAxis.Scale.MinorStep = 1;

            //dung bieu do dang bar de bieu dien
            GP.AddBar("Histogram", histogram, Color.OrangeRed);

            //tra ve gia tri gp
            return GP;

        }
    }
}
