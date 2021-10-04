using System;

namespace QuaverAPI
{
    public class Utils
    {
        public double CalculatePR(double difficulty, double accuracy)
        {
            return difficulty * Math.Pow(accuracy / 98, 6);
        }
    }
}
