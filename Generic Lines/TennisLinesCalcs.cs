using System;

namespace Generic_Lines
{
    class TennisLinesCalcs
    {
        public Random rnd = new Random();

        public decimal ServePercentageP1(int low, int high)
        {
            return ((rnd.Next(low, high)) / 10);
        }

        public decimal ServePercentageP2(int low, int high)
        {
            return ((rnd.Next(low, high)) / 10);
        }
    }
}
