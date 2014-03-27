using MbUnit.Framework;
using Mt4Trading.SimpleMAStrategy;

namespace Mt4Trading.Tests.SimpleMAStrategy
{
    [TestFixture]
    public class SimpleMaTrendTypeCalculatorTests
    {
        [Test]
        public void IsBuyTrend_ShouldReturnCorrectResponse_WhenTimeToBuy()
        {
           Assert.IsTrue(SimpleMaTrendTypeCalculator.IsBuyTrend(2, 1));
        }

        [Test]
        public void IsBuyTrend_ShouldReturnCorrectResponse_WhenTimeToSell()
        {
            Assert.IsFalse(SimpleMaTrendTypeCalculator.IsBuyTrend(1, 2));
        }
    }
}
