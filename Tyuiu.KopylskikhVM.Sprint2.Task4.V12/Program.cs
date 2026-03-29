using Tyuiu.KopylskikhVM.Sprint2.Task4.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение Z              *");
        Console.WriteLine("* с использованием тернарного оператора.                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Если sqrt(x) > 2*y, то z = (7 + 2 / y^2)^x                              *");
        Console.WriteLine("* Иначе z = (3*x^2 - cos(y)^2 + 10) / (y^2 - sin(x^2) + 12)               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, y;

        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}