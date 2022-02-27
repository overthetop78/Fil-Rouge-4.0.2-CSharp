using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fil_Rouge_4._0._2
{
    public abstract class Shape
    {
        protected double longueur = 2;
        protected double largeur = 2;

        public Shape() { }

        public double GetLongueur()
        {
            return longueur;
        }
        public double GetLargeur()
        {
            return largeur;
        }
        public void SetLongueur(double longueur)
        {
            this.longueur = longueur;
        }
        public void SetLargeur(double largeur)
        {
            this.largeur = largeur;
        }

        public abstract string GetResult();

        public abstract double GetAire();

        public abstract double GetPerimetre();

        public override string ToString()
        {
            return "Aire{aire=" + GetAire() + "}, Perimetre{perimetre=" + GetPerimetre() + "}";
        }
    }
}
