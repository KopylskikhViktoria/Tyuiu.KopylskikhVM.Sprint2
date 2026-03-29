using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KopylskikhVM.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ((x >= 0) && (x <= 2) && (y >= Math.Pow(x, 2)) && (y <= 4))
            {
                res = true;
            }
            else
            {
                if ((x > 2) && (y >= 0) && (y <= 4))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }

            return res;
        }
    }
}