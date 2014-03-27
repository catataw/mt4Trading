using System.Runtime.InteropServices;
using RGiesecke.DllExport;

namespace Mt4Trading.SimpleMAStrategy
{
    public static class SimpleMaDecisionCalculator
    {
        [DllExport("CanOpenSellOrder", CallingConvention = CallingConvention.StdCall)]
        public static bool CanOpenSellOrder()
        {
            return bool.Parse("false");
        }

        [DllExport("CanOpenBuyOrder", CallingConvention = CallingConvention.StdCall)]
        public static bool CanOpenBuyOrder()
        {
            return bool.Parse("true");
        }

    }
}
