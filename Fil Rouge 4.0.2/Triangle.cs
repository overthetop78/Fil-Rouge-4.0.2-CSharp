using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fil_Rouge_4._0._2
{
    public class Triangle : Shape
    {
        private double hauteur = 2;

        public Triangle()
        {

        }

        public Triangle(double longueur, double largeur, double hauteur)
        {
            this.hauteur = hauteur;
            this.largeur = largeur;
            this.longueur = longueur;

            if (hauteur > longueur && hauteur > largeur)
            {
                if (largeur + longueur <= hauteur)
                {
                    // erreur de longueur ou largeur inférieures a hauteur
                    double lost = (hauteur + 1) - (largeur + longueur);
                    throw new Exception("Erreur: Addition des deux cotés les plus petits trop courte de " + lost);
                }
            }
            // Si la longueur est plus grande que les autres 
            else if (longueur > hauteur && longueur > largeur)
            {
                if (hauteur + largeur <= longueur)
                {
                    // erreur de hauteur ou largeur inférieures a longueur
                    double lost = (longueur + 1) - (largeur + hauteur);
                    throw new Exception("Erreur: Addition des deux cotés les plus petits trop courte de " + lost);
                }
            }
            else if (largeur > hauteur && largeur > longueur)
            {
                if (hauteur + longueur <= largeur)
                {
                    // erreur de hauteur ou longueur inférieures à largeur
                    double lost = (largeur + 1) - (hauteur + longueur);
                    throw new Exception("Erreur: Addition des deux cotés les plus petits trop courte de " + lost);
                }
            }

        }

        public double GetHauteur()
        {
            return hauteur;
        }

        public void SetHauteur(double hauteur)
        {
            this.hauteur = hauteur;
        }


        public override double GetAire()
        {
            double halfP = GetPerimetre() / 2;
            return Math
                    .Sqrt(halfP * (halfP - GetHauteur()) * (halfP - GetLongueur()) * (halfP - GetLargeur()));
        }

        public override double GetPerimetre()
        {
            return GetHauteur() + GetLargeur() + GetLongueur();
        }

        public override string GetResult()
        {
            return "Triangle :\nHauteur : " + GetHauteur() + "\nLongueur : " + GetLongueur() + "\nLargeur : "
                + GetLargeur() + "\nAire : " + GetAire() + "\nPérimètre : " + GetPerimetre();
        }
        public override string ToString()
        {
            return "Triangle{longueur=" + longueur + ", largeur=" + largeur + ", hauteur=" + hauteur + "}, " + base.ToString();
        }
    }
}
