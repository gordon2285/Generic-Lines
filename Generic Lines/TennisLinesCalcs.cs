using System;

namespace Generic_Lines
{
    class TennisLinesCalcs
    {
        public Random rnd = new Random();

        public static string ServePercentageP1(int low, int high)
        {
            Random rnd = new Random();
            return ((rnd.Next(low, high)) / 10).ToString();
        }

        public static string ServePercentageP2(int low, int high)
        {
            Random rnd = new Random();
            return ((rnd.Next(low, high)) / 10).ToString();
        }
    }
}
