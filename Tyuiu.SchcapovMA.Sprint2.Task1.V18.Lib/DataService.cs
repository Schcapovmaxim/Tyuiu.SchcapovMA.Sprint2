﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SchcapovMA.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c < d);
            res[1] = (a + 696 == b+155) & (c != d);
            res[2] = (a <= b) || (c >= d);
            res[3] = (a +1000> b) && (c == d);
            res[4] = !(!res[0]);
            res[5] = (a < b) ^ (c <= d);
            return res;


        }
    }
}
