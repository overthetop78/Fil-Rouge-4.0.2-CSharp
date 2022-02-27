using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fil_Rouge_4._0._2
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public Rectangle(double longueur, double largeur)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public override double GetAire()
        {
            return GetLargeur() * GetLongueur();
        }

        public override double GetPerimetre()
        {
            return (GetLargeur() + GetLongueur()) * 2;
        }

        public override string GetResult()
        {
            return "Rectangle : \nLargeur : " + GetLargeur() + "\nLongueur : " + GetLongueur() + "\nAire : " + GetAire()
               + "\nPérimètre : " + GetPerimetre();

        }

        public override string ToString()
        {
            return "Rectangle{longueur=" + longueur + ", largeur=" + largeur + "}, " + base.ToString();
        }
    }
}
