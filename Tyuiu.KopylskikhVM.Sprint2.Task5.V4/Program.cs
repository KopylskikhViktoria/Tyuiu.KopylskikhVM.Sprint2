using Tyuiu.KopylskikhVM.Sprint2.Task5.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* По номеру масти определить её название:                                 *");
        Console.WriteLine("* 1 — пики, 2 — трефы, 3 — бубны, 4 — червы                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value;

        Console.WriteLine("Введите номер масти (1-4):");
        value = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((value < 1) || (value > 4))
        {
            res = "Введено неверное значение";
        }
        else
        {
            res = "Это масть: " + ds.FindCardSuit(value);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);

        Console.ReadLine();
    }
}