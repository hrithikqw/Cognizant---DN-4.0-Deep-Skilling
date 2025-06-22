using System;

class Program
{
    static void Main(string[] args)
    {
        double initialAmount = 10000;      // ₹10,000
        double annualGrowthRate = 0.08;    // 8%
        int years = 5;

        double result = FinancialForecast.CalculateFutureValue(initialAmount, annualGrowthRate, years);
        Console.WriteLine($"Predicted value after {years} years: ₹{result:F2}");
    }
}
