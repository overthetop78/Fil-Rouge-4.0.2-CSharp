using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fil_Rouge_4._0._2
{
    public class Cercle : Shape
    {
        private double rayon = 10;
        
        public Cercle()
        {

        }

        public Cercle(double rayon)
        {
            this.rayon = rayon;
        }

        public double GetRayon()
        {
            return rayon;
        }
        public void SetRayon(double rayon)
        {
            this.rayon = rayon;
        }
        public override double GetAire()
        {
            return GetRayon() * GetRayon() * Math.PI;
        }

        public override double GetPerimetre()
        {
            return (GetRayon() + GetRayon()) * Math.PI;
        }

        public override string GetResult()
        {
            return "Cercle : \nRayon : " + GetRayon() + "\nCentre x : " + "\nPi : " + Math.PI + "\nAire : " + GetAire() + "\nPérimètre : "
                + GetPerimetre();

        }

        public override string ToString()
        {
            return "Cercle{rayon=" + rayon + "}, " + base.ToString();
        }
    }
}
