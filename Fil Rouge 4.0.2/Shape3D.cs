using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fil_Rouge_4._0._2
{
    public class Shape3D
    {
        private readonly Shape shape;
        private readonly double profondeur;

        public Shape3D(Shape shape, double profondeur)
        {
            this.shape = shape;
            this.profondeur = profondeur;
        }

        public double GetVolume()
        {
            return this.shape.GetAire() * this.profondeur;
        }

        public string GetResult()
        {
            return "Volume : " + GetVolume();
        }

        public override string ToString()
        {
            return "Volume{profondeur=" + profondeur + ", volume=" + GetVolume() + "}";
        }

    }
}
