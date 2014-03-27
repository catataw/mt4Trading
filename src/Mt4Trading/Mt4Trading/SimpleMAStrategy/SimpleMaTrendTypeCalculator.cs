using System;
namespace Mt4Trading.SimpleMAStrategy
{
    public static class SimpleMaTrendTypeCalculator
    {
        public static bool IsBuyTrend(double ma21Price, double ma70Price )
        {
            Console.WriteLine("Is BuyTrend executing. ma21Price={0}, ma70Price={1}", ma21Price, ma70Price);
            return (ma21Price>ma70Price);
        }
    }
}
