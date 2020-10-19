using System;

namespace class_library
{
    public static class Randomiser
    {
        public static double GetRandomScore()
        {
            Random rand = new Random();
            return rand.NextDouble() * 10;
        }
    }
}
