using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //declartion of tools
            Graphics G = this.CreateGraphics();
            SolidBrush drawbrush1 = new SolidBrush(Color.FromArgb(222, 41, 56));
            SolidBrush drawbrush = new SolidBrush(Color.FromArgb(0, 123, 174));
            SolidBrush drawbrush2 = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial Black", 41, FontStyle.Bold);  
            
            //drawing and rotation of logo (Ellipse for rounding edges unless otherwise specified)
            G.TranslateTransform(270, 230);
            G.RotateTransform(315);
            //top left image
            G.FillEllipse(drawbrush1, 0, 0, 20, 20);
            G.FillRectangle(drawbrush1, 10, 0, 135, 140);
            G.FillRectangle(drawbrush1, 0, 10, 135, 120);
            G.FillEllipse(drawbrush1, 0, 120, 20, 20);
            //top right image
            G.FillEllipse(drawbrush1, 280, 0, 20, 20);
            G.FillRectangle(drawbrush1, 160, 0, 130, 140);
            G.FillRectangle(drawbrush1, 160, 10, 140, 120);
            G.FillEllipse(drawbrush1, 280, 120, 20, 20);
            //inner dots of both top immages 
            //left image dots
            G.FillPie(drawbrush2, 20, 20, 50, 50, 120, 360);
            G.FillPie(drawbrush2, 75, 70, 50, 50, 120, 360);
            //right image dot
            G.FillPie(drawbrush2, 202, 45, 50, 50, 120, 360);
            //large blue bottom image 
            G.FillRectangle(drawbrush, 0, 160, 300, 130);
            G.FillRectangle(drawbrush, 10, 150, 280, 150);
            G.FillEllipse(drawbrush, 0, 150, 20, 20);
            G.FillEllipse(drawbrush, 0, 280, 20, 20);
            G.FillEllipse(drawbrush, 280, 150, 20, 20);
            G.FillEllipse(drawbrush, 280, 280, 20, 20);
            //text for logo
            G.DrawString("Domino's\nPizza", drawFont, drawbrush2, 0, 150);
            G.ResetTransform();

        }
    }
}
