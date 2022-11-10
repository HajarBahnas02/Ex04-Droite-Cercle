using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    
        class Cercle
        {
            private Point C; //le centre
            private int r;   //le rayon
            public Cercle(Point C, int r)
            {
                this.C = C;
                this.r = r;
            }

            public Point GetC()
            {
                return C;
            }

            public void SetC(Point centre)
            {
                this.C = centre;
            }

            public double GetR()
            {
                return r;
            }

            public void SetR(int rayon)
            {
                this.r = rayon;
            }

            public bool Egal(Point centre, int rayon)
            {
                if ((this.C == centre) && (this.r == rayon))
                    return true;
                else
                    return false;
            }




            public double Circonference()
            {
                return Math.Round(2 * Math.PI * r);
            }

            public double CircleArea(double r)
            {
                return Math.PI * (r * r);
            }
        }
    }