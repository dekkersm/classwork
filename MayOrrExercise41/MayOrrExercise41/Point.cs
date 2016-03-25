using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MayOrrExercise41
{
    class Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public string ToString()
        {
            return "(" + " " + x + " " + "," + " " + y + " " + ")";
        }

        public double Distance(Point p1)
        {
            return Math.Sqrt(Math.Pow((this.x - p1.x), 2) + Math.Pow((this.y - p1.y), 2));
        }
    }
}
