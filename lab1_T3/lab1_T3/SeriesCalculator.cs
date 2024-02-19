using System;

namespace lab1_T3
{
    public delegate double SeriesTerm(int n);
    class SeriesCalculator
    {
        public static double CalculateSeriesSum(SeriesTerm termDelegate, double precision)
        {
            double sum = 0.0;
            double termValue = termDelegate(0);
            int n = 0;

            while (Math.Abs(termValue) >= precision)
            {
                sum += termValue;
                n++;
                termValue = termDelegate(n);
            }

            return sum;
        }

        static double Factorial(int n)
        {
            double result = 1.0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static double Series1Term(int n)
        {
            return 1.0 / Math.Pow(2, n);
        }

        public static double Series2Term(int n)
        {
            return 1.0 / Factorial(n + 1);
        }

        public static double Series3Term(int n)
        {
            return Math.Pow(-1, n + 1) * 1.0 / Math.Pow(2, n);
        }


    }
}
