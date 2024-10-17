using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SchcapovMA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                    {
                        if (n == 31)
                        {
                            n = 1; m++;
                        }
                        else n++;
                        if (n < 10) return $"0{n}.0{m}.{g}";
                        return $"{n}.{m}.{g}";
                    }
                case 10:
                    {
                        if (n == 31)
                        {
                            n = 1; m++;
                        }
                        else n++;
                        if (n < 10) return $"0{n}.{m}.{g}";
                        return $"{n}.{m}.{g}";
                    }
                case 2:
                    {
                        if (n == 28)
                        {
                            n = 1; m++;
                        }
                        else n++;
                        if (n > 10) return $"0{n}.0{m}.{g}";
                        return $"{n}.0{m}.{g}";
                    }
                case 4:
                case 6:
                case 9:
                    {
                        if (n == 30)
                        {
                            n = 1; m++;
                            if (m == 10) return $"0{n}.{m}.{g}";
                        }
                        else n++;
                        if (n < 10) return $"0{n}.0{m}.{g}";
                        return $"0{n}.0{m}.{g}";
                    }
                case 11:
                    {
                        if (n == 30)
                        {
                            n = 1; m++;
                        }
                        else n++;
                        if (n < 10) return $"0{n}.{m}.{g}";
                        return $"{n}.{m}.{g}";
                    }
                case 12:
                    {
                        if (n == 31)
                        {
                            n = 1; m = 1; g++;
                            return $"0{n}.0{m}.{g}";
                        }
                        else n++;
                        if (n < 10) return $"0{n}.{m}.{g}";
                        return $"{n}.{m}.{g}";
                    }
                default: return $"{n}.{m}.{g}";

            }
        }
    }
}
