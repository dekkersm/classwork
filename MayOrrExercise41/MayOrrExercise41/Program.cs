using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MayOrrExercise41
{
    class Program
    {
        static void Main(string[] args)
        { 
            int x, y;
            Point[] pointArr = new Point[10];
            Random rand = new Random();
            for (int i = 0; i < pointArr.Length; i++)
            {
                x = rand.Next(-10, 10);
                y = rand.Next(-10, 10);
                pointArr[i] = new Point(x, y);
                Console.WriteLine(pointArr[i].ToString());
            }
            double distance = 0;
            Point farPoint1 = new Point();
            Point farPoint2 = new Point();
            for (int i = 0; i < pointArr.Length; i++)
            {
                for (int j = i + 1 ; j < pointArr.Length; j++)
                {
                    double tempDistance = pointArr[i].Distance(pointArr[j]);
                    if (distance < tempDistance)
                    {
                        distance = tempDistance;
                        farPoint1 = pointArr[i];
                        farPoint2 = pointArr[j];
                    }
                }
            }
            Console.WriteLine("the farthest two points are " + farPoint1.ToString() + " and " + farPoint2.ToString());

            int[] quadrant = new int[4];
            for (int i = 0; i < quadrant.Length; i++)
            {
                quadrant[i] = 0;
            }
            for (int i = 0; i < pointArr.Length; i++)
            {
                if (pointArr[i].GetX() > 0)
                {
                    if (pointArr[i].GetY() > 0)
                    {
                        quadrant[0]++;
                    }
                    else
                        quadrant[1]++;
                }
                else
                {
                    if (pointArr[i].GetY() > 0)
                    {
                        quadrant[3]++;
                    }
                    else
                        quadrant[2]++;
                }
            }

            int maxValue = quadrant.Max();
            int location = Array.IndexOf(quadrant, maxValue)+1;
            Console.WriteLine("the quadrant with the most points is : "+location);
        }
    }
}
