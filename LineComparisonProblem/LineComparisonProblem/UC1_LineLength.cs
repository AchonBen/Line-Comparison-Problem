using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class UC1LineLength
    {
            public static void Distance()
            {
                Console.WriteLine("Please Enter Coordinates of x1:");
                var x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Coordinate of y1:");
                var y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Coordinates x2:");
                var x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Coodinate of y2:");
                var y2 = Convert.ToDouble(Console.ReadLine());

                var finalResult = Distance(x1, x2, y1, y2);
                Console.WriteLine("Distance between coordinates {0},{1} and {2},{3} is {4:F}", x1, x2, y1, y2, finalResult);
            }

            private static double Distance(double x1, double x2, double y1, double y2)
            {
                var temp1 = Math.Pow((x2 - x1), 2);
                var temp2 = Math.Pow((y2 - y1), 2);
                var result = Math.Sqrt(temp1 + temp2);

                return result;
            }

        
    }
}
