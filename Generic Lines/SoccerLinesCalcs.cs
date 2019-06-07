using System;

namespace Generic_Lines
{
    class SoccerLinesCalcs
    {
        public static string SoccerHandicap(int a, int b)
        {
            Random rnd = new Random();
            return  ((rnd.Next(a, b)) / 4).ToString();
        }

        public static string SoccerTotal(int c, int d)
        {
            Random rnd2 = new Random();
            return SoccerTotalString(c, d, rnd2).ToString();
        }
        //converting to string as going in text box and was moaning about error converting from decimal to string
        private static decimal SoccerTotalString(int c, int d, Random rnd2)
        {
            return rnd2.Next(c, d) / 4;
        }
    }
}
