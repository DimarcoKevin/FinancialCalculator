using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialCalculator.Objects {
    public partial class pieChart : UserControl {

       // PictureBox 
       
        
        public pieChart() {
            InitializeComponent();
            math();
        }


        public void math() {


            Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics graphics= Graphics.FromImage(bitmap);
            //Graphics graphics = pictureBox1.CreateGraphics();

            //int i1 = 10; //Int32.Parse(textBox1.Text);
            //int i2 = 10;
            //int i3 = 10;
            //int i4 = 10;
            //int i5 = 10;

            //float total = i1 + i2 + i3 + i4 + i5;

            //float deg1 = (i1 / total) * 360;
            //float deg2 = (i2 / total) * 360;
            //float deg3 = (i3 / total) * 360;
            //float deg4 = (i4 / total) * 360;
            //float deg5 = (i5 / total) * 360;

            //Rectangle rect = new Rectangle(10, 10, 150, 150);

            //Brush brush1 = new SolidBrush(Color.Red);
            //Brush brush2 = new SolidBrush(Color.Blue);
            //Brush brush3 = new SolidBrush(Color.Maroon);
            //Brush brush4 = new SolidBrush(Color.Navy);
            //Brush brush5 = new SolidBrush(Color.YellowGreen);

            //graphics.FillPie(brush1, rect, 0, deg1);

            //graphics.FillPie(brush1, rect, deg1, deg2);

            Pen pen = new Pen(Color.Black, 2);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(10, 250, 450, 300);

            //graphics.DrawEllipse(pen, 10, 10, 300, 300);

            //graphics.DrawPie(pen, rect, 200, 150);

        }

        
    }
}
