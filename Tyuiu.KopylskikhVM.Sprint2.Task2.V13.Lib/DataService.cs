using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KopylskikhVM.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x == 4 && y >= 2 && y <= 8)
            {
                return true;
            }
            else if (y == 6 && x >= 3 && x <= 13)
            {
                return true;
            }
            else if (x >= 9 && x <= 12 && y >= 3 && y <= 10)
            {
                return true;
            }
            else if (x >= 8 && x <= 12 && y >= 5 && y <= 10)
            {
                return true;
            }
            else if (x >= 8 && x <= 10 && y >= 11 && y <= 12)
            {
                return true;
            }
            else if (x >= 6 && x <= 8 && y >= 10 && y <= 11)
            {
                return true;
            }
            else if (x == 7 && y == 12)
            {
                return true;
            }
            else if (x == 13 && (y == 6 || y == 7 || y == 8))
            {
                return true;
            }
            else if (x == 3 && (y == 6 || y == 11))
            {
                return true;
            }
            else if (x == 4 && y == 11)
            {
                return true;
            }
            else if (x == 5 && y == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}