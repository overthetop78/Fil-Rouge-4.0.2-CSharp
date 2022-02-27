using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fil_Rouge_4._0._2
{
    public class TotalShape
    {
        private readonly ArrayList shapeArrayList;

        public TotalShape()
        {
            this.shapeArrayList = new ArrayList();
        }

        public double GetAireTotal()
        {
            double totalAire = 0;
            foreach (Shape shape in shapeArrayList)
            {
                totalAire += shape.GetAire();
            }
            return totalAire;
        }

        public double GetPerimetreTotal()
        {
            double totalPerimetre = 0;
            foreach (Shape shape in this.shapeArrayList)
            {
                totalPerimetre += shape.GetPerimetre();
            }
            return totalPerimetre;
        }

        public void AddShapeToList(Shape shape)
        {
            this.shapeArrayList.Add(shape);
        }

        public string GetResult()
        {
            return "Total Périmètre des formes : " + GetPerimetreTotal() +
                "\nTotal Aire des formes : " + GetAireTotal();
        }

        public override string ToString()
        {
            return "Total{Aire=" + GetAireTotal() + ", Perimetre=" + GetPerimetreTotal() + "}";
        }
    }
}
