using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficzne3
{
    internal static class Utils
    {
        public static int Binom(int n, int k)
        {
            int numerator = 1;
            int denumerator = 1;

            for(int i = 1; i <= k; i++)
            {
                numerator *= n + 1 - i;
                denumerator *= i;
            }

            return numerator / denumerator;
        }

        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
