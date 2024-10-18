using Tyuiu.SchcapovMA.Sprint2.Task7.V9.Lib;
namespace Tyuiu.SchcapovMA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = Math.PI / 9;
            double y = 0.2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}