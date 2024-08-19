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

namespace Mn_project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // tao bien luu hinh 
            Image<Bgr, byte> hinhhienthi = new Image<Bgr, byte>(@"F:\xu_ly_anh\lena_color.png");
            imageBox_hienthi.Image = hinhhienthi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
