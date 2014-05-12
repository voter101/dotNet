using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3._2._3
{
    class Zegar
    {
        double przesuniecieMinutowe = 2*Math.PI / 60.0;
        double przesuniecieGodzinowe = 2*Math.PI / 12.0;


        public Point wyliczWspolrzedneGodzinowej(Point srodek, double dlugoscWskazowki)
        {
            DateTime czas = DateTime.Now;
            double procentMinuty = czas.Minute / 60;
            double kat = -90 * Math.PI/180 +  ((przesuniecieGodzinowe * (czas.Hour % 12)) + (procentMinuty * przesuniecieGodzinowe));
            return new Point(srodek.X + Convert.ToInt32(dlugoscWskazowki * Math.Cos(kat)),srodek.Y + Convert.ToInt32(dlugoscWskazowki*Math.Sin(kat)));
        }
        public Point wyliczWspolrzedneMinutowej(Point srodek, double dlugoscWskazowki)
        {
            DateTime czas = DateTime.Now;
            double kat = -90 * Math.PI / 180 + (przesuniecieMinutowe * czas.Minute);
            return new Point(srodek.X + Convert.ToInt32(dlugoscWskazowki * Math.Cos(kat)), srodek.Y + Convert.ToInt32(dlugoscWskazowki * Math.Sin(kat)));

            
        }
        public Point wyliczWspolrzedneSekundowej(Point srodek, double dlugoscWskazowki)
        {
            DateTime czas = DateTime.Now;
            double kat = -90 * Math.PI / 180 + (przesuniecieMinutowe * czas.Second);
            return new Point(srodek.X + Convert.ToInt32(dlugoscWskazowki * Math.Cos(kat)), srodek.Y + Convert.ToInt32(dlugoscWskazowki * Math.Sin(kat)));


        }
    }
}
