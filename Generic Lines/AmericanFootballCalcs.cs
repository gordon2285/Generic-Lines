using System;

namespace Generic_Lines
{
    class AmericanFootballCalcs
    {
        public static decimal AmericanFootballHandicap(int a, int b)
        {
            Random rnd = new Random();
            return ((rnd.Next(a, b)) / 2);
        }

        public static decimal AmericanFootballTotal(int c, int d)
        {
            Random rnd2 = new Random();
            return ((rnd2.Next(c, d)) / 2);
        }
    }
}
