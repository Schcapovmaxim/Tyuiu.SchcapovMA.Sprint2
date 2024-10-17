using Tyuiu.SchcapovMA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.SchcapovMA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            
            string res = ds.FindDateOfNextDay(2024,12,31);
            string wait = "01.01.2025";
            Assert.AreEqual(res, wait);
           


        }
    }
}