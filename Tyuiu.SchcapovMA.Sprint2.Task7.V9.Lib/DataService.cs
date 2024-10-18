using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SchcapovMA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)

        {
            string ystr = Convert.ToString(y);
            int znak = ystr.Length;
            bool res = (y > 0 && y < 0.5) && (y < Math.Round(Math.Sin(x),znak-2));
            return res;
        }
    }
}
