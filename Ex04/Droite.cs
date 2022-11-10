using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Droite
    {
        //declaration variables
        private Point X;
        private Point Y;
        public Droite(double pX1, double pY1)
        {
            this.PointX1 = pX1;
            this.PointY = pY1;
        }
        public double PointX1
        {
            get { return PointX; }
            set { X = value; }

        }
        public double PointY
        {
            get { return PointY; }
            set { Y = value; }
        }
        static public bool parallelisme(Point A, Point B, Point C, Point D)
        {
            double D1 = B.PointY - A.PointY / B.PointX - A.PointX;
            double D2 = D.PointY - C.PointY / D.PointX - C.PointX;
            if (D1 == D2)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        static public bool perpendicularite(Point A, Point B, Point C, Point D)
        {
            double D3 = B.PointY - A.PointY / B.PointX - A.PointX;
            double D4 = D.PointY - C.PointY / D.PointX - C.PointX;
            return (D3 * D4 == 1);
        }
        static public void intersection(Droite L, Droite H)
        {
            if ((Droite.parallelisme(L, H) == false) && (Droite.perpendicularite(L, H) == false))
            {
                Console.WriteLine("il y a une intersection");
            }
        }
        static public bool egalite(Point A, Point B, Point C, Point D)
        {
            return (A.PointX1 == C.PointX1 && A.PointY1 == C.PointY1 && B.PointX1 == D.PointX1 && B.PointY1 == D.PointY1);


        }
    }
}