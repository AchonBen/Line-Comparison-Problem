using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class UC3_GreaterThanOrEqual
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
            Console.WriteLine("Please Enter Which Operation to Perform:");
            Console.WriteLine("1. Equality");
            Console.WriteLine("2. Greater Than or Lesser Than");
            var selectedOperation = Console.ReadLine();
            if (selectedOperation != "1")
            {
                Console.WriteLine("Please choose the reference of line(1/2)");
                var selectedLine = Console.ReadLine();
                if (selectedLine == "1")
                {
                    if (selectedOperation == "2")
                    {
                        if (IsGreaterOrLesser(lineOneLength, lineTwoLength))
                        {
                            Console.WriteLine("The Line {0} is Greater by {1:F} unit", selectedLine, lineOneLength - lineTwoLength);
                        }
                        else
                        {
                            Console.WriteLine("The Line {0} is Lesser by {1:F} unit", selectedLine, lineTwoLength - lineOneLength);
                        }
                    }
                }
                else
                {
                    if (IsGreaterOrLesser(lineTwoLength, lineOneLength))
                    {
                        Console.WriteLine("The Line {0} is Greater by {1:F} unit", selectedLine, lineTwoLength - lineOneLength);
                    }
                    else
                    {
                        Console.WriteLine("The Line {0} is Lesser by {1:F} unit", selectedLine, lineOneLength - lineTwoLength);
                    }
                }
            }


            if (selectedOperation == "1")
            {
                var isEqualOrNot = IsEquals(lineOneLength, lineTwoLength);

                if (isEqualOrNot)
                {
                    Console.WriteLine("Lengths are equal");
                }
                else
                {
                    Console.WriteLine("Lengths are not equal");
                }
            }
        }
        private static double Distance(double coordinatex1, double coordinatex2, double coordinatey1, double coordinatey2)
        {
            var temp1 = Math.Pow((coordinatex2 - coordinatex1), 2);
            var temp2 = Math.Pow((coordinatey2 - coordinatey1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            return result;
        }

        private static bool IsEquals(double lineOneLength, double lineTwoLength)
        {
            var isEqualLengths = lineOneLength.Equals(lineTwoLength);
            return isEqualLengths;
        }
        private static bool IsGreaterOrLesser(double lineOneLength, double lineTwoLength)
        {
            var isGreater = lineOneLength > lineTwoLength;
            return isGreater;
        }
    }
}
