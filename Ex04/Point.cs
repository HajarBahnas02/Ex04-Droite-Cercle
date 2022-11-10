using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{

        public class Point
        {
            private int X;
            private int Y;
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int GetX()
            {
                return (X);
            }
            public int GetY()
            {
                return (Y);
            }
            public void SetX(int x1)
            {
                this.X = x1;
            }
            public void SetY(int y1)
            {
                this.Y = y1;
            }
            public double Distance(Point p1)
            {
                return (Math.Sqrt(Math.Pow((p1.X - this.X), 2) + Math.Pow((p1.Y - this.Y), 2)));

            }
            public bool Egalité(Point p1)
            {
                if ((p1.X == this.Y) && (p1.Y == this.Y))
                {
                    return true;
                }
                else
                    return false;
            }

            public void translation(int x1, int y1)
            {
                X += x1;
                Y = Y + y1;
            }
            public int Lineair(Point P1, Point P2)
            {
                if ((P1.X - this.X) / (P2.X - this.X) == (P1.Y - this.Y) / (P2.Y - this.Y))
                    return 1;
                else
                    return 0;
            }
        }
    }
}
}
