using Tyuiu.SchcapovMA.Sprint2.Task4.V13.Lib;
namespace Tyuiu.SchcapovMA.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x,y);
            double wait = 30;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 90;
            double res = ds.Calculate(x,y);
            double wait = 0.002;
            Assert.AreEqual(wait, res);
        }
    }
}