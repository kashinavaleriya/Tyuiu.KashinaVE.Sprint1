
using Tyuiu.KashinaVE.Sprint1.Task6.V3.Lib;

namespace Tyuiu.KashinaVE.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет мир";

            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "тр";
            Assert.AreEqual(wait, res);
        }
    }
}
