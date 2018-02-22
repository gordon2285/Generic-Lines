using System;

namespace Generic_Lines
{
    class SoccerLinesCalcs
    {
        public static decimal SoccerHandicap(int a, int b)
        {
            Random rnd = new Random();
            return ((rnd.Next(a, b)) / 4);
        }

        public static decimal SoccerTotal(int c, int d)
        {
            Random rnd2 = new Random();
            return ((rnd2.Next(c, d)) / 4);
        }
    }
}
