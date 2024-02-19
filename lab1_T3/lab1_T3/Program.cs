using System;

namespace lab1_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...
            double series1Sum = SeriesCalculator.CalculateSeriesSum(SeriesCalculator.Series1Term, 1e-6);
            Console.WriteLine($"Sum of series 1: {series1Sum}");

            // 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...
            double series2Sum = SeriesCalculator.CalculateSeriesSum(SeriesCalculator.Series2Term, 1e-6);
            Console.WriteLine($"Sum of series 2: {series2Sum}");

            // -1 + 1/2 - 1/4 + 1/8 - 1/16 + ...
            double series3Sum = SeriesCalculator.CalculateSeriesSum(SeriesCalculator.Series3Term, 1e-6);
            Console.WriteLine($"Sum of series 3: {series3Sum}");
        }
    }
}
