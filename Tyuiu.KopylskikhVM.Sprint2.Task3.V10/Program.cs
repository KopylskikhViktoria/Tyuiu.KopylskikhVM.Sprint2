using Tyuiu.KopylskikhVM.Sprint2.Task3.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Вложенные операторы if-else                                       *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение функции Y по заданной формуле.                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*  y = {                                                                  *");
        Console.WriteLine("*      x - ((x+15)/(x-4))^x,           если x > 0                         *");
        Console.WriteLine("*      (x^2+cos(x^2)-3)/(x^2-sin(x^2)+2), если x = 0                      *");
        Console.WriteLine("*      (5+1/x^2)^x,                   если -14 < x < 0                    *");
        Console.WriteLine("*      x + 10x - (1/x),               если x < -14                        *");
        Console.WriteLine("*  }                                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;

        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x));

        Console.ReadLine();
    }
}