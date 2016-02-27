using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.BlueViolet, (float)1);
            Point pn1 = new Point(0, 100);
            Point pn2 = new Point(0, 100);
            for (double i = 0; i < 900; i += 0.3)
            {
                pn1.X = (int)Math.Round(i);
                pn1.Y = (int)Math.Round(45 * Math.Sin(i / 20)) + 100;
                this.CreateGraphics().DrawLine(p, pn1, pn2);
                pn2.X = pn1.X;
                pn2.Y = pn1.Y;

            }
            CreateGraphics().DrawLine(Pens.Black, 0, 100, 900, 100);
            CreateGraphics().DrawLine(Pens.Black, 441, 0, 441, 200);
            CreateGraphics().DrawRectangle(Pens.Red, 0, 0, 900, 200);
        }
    }
}
                   
  
    


