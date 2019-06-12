using System;

namespace Generic_Lines
{
    class BasketballLinesCalcs
    {
        public static string BasketballHandicap(int a, int b)
        {
            Random rnd = new Random();
            return ((rnd.Next(a, b)) / 2).ToString();
        }

        public static string BasketballTotal(int c, int d)
        {
            Random rnd2 = new Random();
            return ((rnd2.Next(c, d)) / 2).ToString();
        }
    }
}
