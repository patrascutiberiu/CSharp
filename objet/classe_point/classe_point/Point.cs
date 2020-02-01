using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_point
{
    class Point
    {
        private float x;
        private float y;

        public float X
        {
            get
            {
                return x;
            }

        }
        public float Y
        {
            get
            {
                return y;
            }

        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Point()
        {
            x = 0;
            y = 0;
        }

        /// <summary>
        /// constructeur parametré
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(float _x, float _y)
        {
            x = _x;
            y = _y;
        }


        public void deplacer(float _newDeplaceX, float _newDeplaceY)
        {
            x =x+ _newDeplaceX;
            y =y+ _newDeplaceY;
        }


        public Point(Point _point)
        {
            x = _point.x;
            y = _point.y;
        }


        public Point symX()
        {
            Point xOppose = new Point(x,-y);           
            return xOppose;
        }


        public Point symY()
        {
            Point yOppose = new Point(-x,y);           
            return yOppose;
        }


        public Point symOrigine()
        {
            Point oOppose = new Point(this);
            oOppose.x = x * -1;
            oOppose.y = y * -1;
            return oOppose;
        }


        public void permuteXY()
        {
            float z;
            z = x;
            x = y;
            y = z;
        }


        public void affichage()
        {
            Console.WriteLine(ToString());
        }


        public override string ToString()
        {
            return string.Format("X = {0} , et y = {1} ", x, y);
        }
    }
}
