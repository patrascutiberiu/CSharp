using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPoint
{
    public class Point
    {
        int x;
        int y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(Point clonePoint)
        {
            x = clonePoint.x;
            y = clonePoint.y;
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Deplacer(int _newX, int _newY)
        {
            x = x + _newX;
            y = y + _newY;
        }

        public Point symetriqueX()
        {
            Point xOrdonne = new Point(x, -y);
            return xOrdonne;
        }

        public Point symetriqueY()
        {
            Point yAbscisse = new Point(-x, y);
            return yAbscisse;
        }

        public Point symetriqueOrigine()
        {
            Point pointOrigine = new Point(this);
            pointOrigine.x = x * -1;
            pointOrigine.y = y * -1;

            return pointOrigine;
        }

        public void PermuterXY()
        {
            int z;
            z = x;
            x = y;
            y = z;
        }

        public override string ToString()
        {
            return "x " + x + " y " + y;
        }

    }
}
