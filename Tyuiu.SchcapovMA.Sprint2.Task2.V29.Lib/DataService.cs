using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SchcapovMA.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)     
        {
            bool res;
            bool a = ((x < 3 && (y < 6 && y > 3)) || ((x < 5 && x > 2) && (y > 2 && y < 8)));
            bool b = (((x > 5 && x < 13) && (y > 4 && y < 8)) || ((x > 8 && x < 13) && (y > 2 && y < 5)));
            bool c = (((x > 9 && x < 13) && (y > 7 && y < 12)) || ((x == 13) && (y > 5 && y < 9)));
            bool d = (((x == 6) && (y > 7 && y < 12)) || ((x > 3 && x < 6) && (y > 10 && y < 13)));
            bool e = (((x == 3) && (y == 11)) || ((x == 10) && (y == 12)));
            if ( a || b || c || d || e)
            {res = true; }
            else {res = false; }
            return res;
        }
    }
}
