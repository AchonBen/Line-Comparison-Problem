using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class UC2_EqualityOfTwoLines
    {
        public static void Distance()
        {
            Console.WriteLine("Please Enter Coordinates of Line one:");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Coordinates of Line two:");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Coordinates of Line three:");
            var x3 = Convert.ToDouble(Console.ReadLine());
            var y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Coordinates of Line four:");
            var x4 = Convert.ToDouble(Console.ReadLine());
            var y4 = Convert.ToDouble(Console.ReadLine());

            var lineOneLength = Distance(x1, x2, y1, y2);
            var lineTwoLength = Distance(x3, x4, y3, y4);
            var isEqualLengths = lineOneLength.Equals(lineTwoLength);
            if (isEqualLengths)
            {
                Console.WriteLine("Lengths are equal");
            }
            else
            {
                Console.WriteLine("Lengths are not equal");
            }
        }
        private static double Distance(double coordinatex1, double coordinatex2, double coordinatey1, double coordinatey2)
        {
            var temp1 = Math.Pow((coordinatex2 - coordinatex1), 2);
            var temp2 = Math.Pow((coordinatey2 - coordinatey1), 2);
            var result = Math.Sqrt(temp1 + temp2);


            return result;
        }
    }
}
