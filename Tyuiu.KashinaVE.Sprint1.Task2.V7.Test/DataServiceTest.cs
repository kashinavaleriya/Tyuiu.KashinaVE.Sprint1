using Tyuiu.KashinaVE.Sprint1.Task2.V7.Lib;

namespace Tyuiu.KashinaVE.Sprint1.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            var res = ds.CalculateSquareCircle(x);
            Assert.AreEqual(50.265, res);
        }
    }
}
