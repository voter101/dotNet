using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _3._2._3
{
    public partial class Form1 : Form
    {
        Timer timer;
        private Zegar zegar = new Zegar();
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            timer.Start();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            this.rysujZegar();
        }

        private void rysujZegar()
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Black, 50, 50, this.Width - 150, this.Height - 150);
            rysujMinutowa(g);
            rysujGodzinowa(g);
            rysujSekundowa(g);
            g.Dispose();
        }
        private void rysujMinutowa(Graphics g)
        {
            Point srodek = new Point((this.Width - 150)/2 +50, (this.Height - 150)/2 +50);
            Point wskazowka = zegar.wyliczWspolrzedneMinutowej(srodek, this.Width/4);
            g.DrawLine(new Pen(Color.Black,2), srodek, wskazowka);

        }
        private void rysujGodzinowa(Graphics g)
        {
            Point srodek = new Point((this.Width - 150) / 2 + 50, (this.Height - 150) / 2 + 50);
            Point wskazowka = zegar.wyliczWspolrzedneGodzinowej(srodek, this.Width / 6);
            g.DrawLine(new Pen(Color.Black,4), srodek, wskazowka);

        }
        private void rysujSekundowa(Graphics g)
        {
            Point srodek = new Point((this.Width - 150) / 2 + 50, (this.Height - 150) / 2 + 50);
            Point wskazowka = zegar.wyliczWspolrzedneSekundowej(srodek, this.Width / 3);
            g.DrawLine(new Pen(Color.Black, 1), srodek, wskazowka);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

        }


       
       
    }
}
