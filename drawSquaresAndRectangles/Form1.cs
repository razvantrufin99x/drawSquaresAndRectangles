using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawSquaresAndRectangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen pen0 = new Pen(Color.Black);

        public void drawSquare()
        {
            if (dotCtrl1.Left < dotCtrl2.Left && dotCtrl1.Top < dotCtrl2.Top)
            {
                g.DrawRectangle(pen0, dotCtrl1.Left, dotCtrl1.Top, (int)Math.Abs(dotCtrl2.Left - dotCtrl1.Left),  (int)Math.Abs( dotCtrl2.Top - dotCtrl1.Top));
            }
            else if (dotCtrl1.Left > dotCtrl2.Left && dotCtrl1.Top < dotCtrl2.Top)
            {
                g.DrawRectangle(pen0, dotCtrl2.Left, dotCtrl1.Top, (int)Math.Abs(dotCtrl2.Left - dotCtrl1.Left), (int)Math.Abs(dotCtrl1.Top - dotCtrl2.Top));
            }
            else if (dotCtrl1.Left < dotCtrl2.Left && dotCtrl1.Top > dotCtrl2.Top)
            {
                g.DrawRectangle(pen0, dotCtrl1.Left, dotCtrl2.Top, (int)Math.Abs(dotCtrl2.Left - dotCtrl1.Left), (int)Math.Abs(dotCtrl2.Top - dotCtrl1.Top));
            }
            else if (dotCtrl1.Left > dotCtrl2.Left && dotCtrl1.Top > dotCtrl2.Top)
            {
                g.DrawRectangle(pen0, dotCtrl2.Left, dotCtrl2.Top, (int)Math.Abs(dotCtrl2.Left - dotCtrl1.Left), (int)Math.Abs(dotCtrl1.Top - dotCtrl2.Top));
            }

            if (dotCtrl3.Left < dotCtrl4.Left && dotCtrl3.Top < dotCtrl4.Top)
            {
                g.DrawRectangle(pen0, dotCtrl3.Left, dotCtrl3.Top, (int)Math.Abs(dotCtrl4.Left - dotCtrl3.Left), (int)Math.Abs(dotCtrl4.Top - dotCtrl3.Top));
            }
            else if (dotCtrl3.Left > dotCtrl4.Left && dotCtrl3.Top < dotCtrl4.Top)
            {
                g.DrawRectangle(pen0, dotCtrl4.Left, dotCtrl3.Top, (int)Math.Abs(dotCtrl4.Left - dotCtrl3.Left), (int)Math.Abs(dotCtrl3.Top - dotCtrl4.Top));
            }
            else if (dotCtrl3.Left < dotCtrl4.Left && dotCtrl3.Top > dotCtrl4.Top)
            {
                g.DrawRectangle(pen0, dotCtrl3.Left, dotCtrl4.Top, (int)Math.Abs(dotCtrl4.Left - dotCtrl3.Left), (int)Math.Abs(dotCtrl4.Top - dotCtrl3.Top));
            }
            else if (dotCtrl3.Left > dotCtrl4.Left && dotCtrl3.Top > dotCtrl4.Top)
            {
                g.DrawRectangle(pen0, dotCtrl4.Left, dotCtrl4.Top, (int)Math.Abs(dotCtrl4.Left - dotCtrl3.Left), (int)Math.Abs(dotCtrl3.Top - dotCtrl4.Top));
            }
        }
        public void drawLines()
        {
            g.Clear(BackColor);
            g.DrawLine(pen0, dotCtrl1.Left, dotCtrl1.Top, dotCtrl2.Left, dotCtrl2.Top);
            g.DrawLine(pen0, dotCtrl3.Left, dotCtrl3.Top, dotCtrl4.Left, dotCtrl4.Top);
            drawSquare();
            Text = lint(new Point(dotCtrl1.Left, dotCtrl1.Top), new Point(dotCtrl2.Left, dotCtrl2.Top), new Point(dotCtrl3.Left, dotCtrl3.Top), new Point(dotCtrl4.Left, dotCtrl4.Top)).ToString();
        }

        //Example 17-2. Implementation for Testing Whether Line Segments Intersect
/*****************************************************************************
* *
* -------------------------------- lint.c -------------------------------- *
* *
*****************************************************************************/
//#include "geometry.h"
/*****************************************************************************
* *
* --------------------------------- lint --------------------------------- *
* *
*****************************************************************************/

int MAX(int a, int b)
{

    if(a>b){return a;}
    else if(b>a){ return b;}
    else {return -1;}

}

        int MIN(int a, int b)
{

    if(a<b){return a;}
    else if(b<a){ return b;}
    else {return -1;}

}

        int lint(Point p1, Point p2, Point p3, Point p4)
        {
            double z1,
            z2,
            z3,
            z4;
            int s1,
            s2,
            s3,
            s4;
            /*****************************************************************************
            * *
            * Perform the quick rejection test. *
            * *
            *****************************************************************************/
            if (!(MAX(p1.X, p2.X) >= MIN(p3.X, p4.X) && MAX(p3.X, p4.X)
            >= MIN(p1.X, p2.X) && MAX(p1.Y, p2.Y) >= MIN(p3.Y, p4.Y)
            && MAX(p3.Y, p4.Y) >= MIN(p1.Y, p2.Y)))
            {
                //{
                   // return 0;
                //}
                /*****************************************************************************
                * *
                * Determine whether the line segments straddle each other. *
                * *
                *****************************************************************************/
                if ((z1 = ((p3.X - p1.X) * (p2.Y - p1.Y)) - ((p3.Y - p1.Y) * (p2.X - p1.X))) < 0)
                    s1 = -1;
                else if (z1 > 0)
                    s1 = 1;
                else
                    s1 = 0;
                if ((z2 = ((p4.X - p1.X) * (p2.Y - p1.Y)) - ((p4.Y - p1.Y) * (p2.X - p1.X))) < 0)
                    s2 = -1;
                else if (z2 > 0)
                    s2 = 1;
                else
                    s2 = 0;
                if ((z3 = ((p1.X - p3.X) * (p4.Y - p3.Y)) - ((p1.Y - p3.Y) * (p4.X - p3.X))) < 0)
                    s3 = -1;
                else if (z3 > 0)
                    s3 = 1;
                else
                    s3 = 0;
                if ((z4 = ((p2.X - p3.X) * (p4.Y - p3.Y)) - ((p2.Y - p3.Y) * (p4.X - p3.X))) < 0)
                    s4 = -1;
                else if (z4 > 0)
                    s4 = 1;
                else
                    s4 = 0;
                if ((s1 * s2 <= 0) && (s3 * s4 <= 0))
                    return 1;
                /*****************************************************************************
                * *
                * Return that the line segments do not intersect. *
                * *
                *****************************************************************************/
                //return 0;
            }
            return 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();

        }
    }
}
