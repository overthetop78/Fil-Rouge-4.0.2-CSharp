using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fil_Rouge_4._0._2
{
    public class TotalVolume
    {
        public ArrayList shapes3DArrayList;

        public TotalVolume()
        {
            this.shapes3DArrayList = new ArrayList();

        }

        public double GetTotalVolume()
        {
            double volume = 0;
            foreach (Shape3D shape3D in this.shapes3DArrayList)
            {
                volume += shape3D.GetVolume();
            }
            return volume;
        }

        public void AddShape3DToList(Shape3D shape3D)
        {
            this.shapes3DArrayList.Add(shape3D);
        }

        public string GetResult()
        {
            return "Volume total des formes : " + this.GetTotalVolume();
        }

        public override string ToString()
        {
            return "Volume{total=" + GetTotalVolume() + "}";
        }

    }
}
