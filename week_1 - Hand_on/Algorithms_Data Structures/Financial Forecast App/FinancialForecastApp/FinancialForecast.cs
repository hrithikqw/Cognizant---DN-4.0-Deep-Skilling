using System;

public static class FinancialForecast
{
    public static double CalculateFutureValue(double presentValue, double annualGrowthRate, int years)
    {
        if (years == 0)
            return presentValue;

        return CalculateFutureValue(presentValue, annualGrowthRate, years - 1) * (1 + annualGrowthRate);
    }

    public static double CalculateFutureValueIterative(double presentValue, double annualGrowthRate, int years)
    {
        for (int i = 0; i < years; i++)
        {
            presentValue *= (1 + annualGrowthRate);
        }
        return presentValue;
    }
}
