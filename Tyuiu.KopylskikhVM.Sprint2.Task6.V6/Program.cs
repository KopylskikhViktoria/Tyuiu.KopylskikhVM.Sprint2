using Tyuiu.KopylskikhVM.Sprint2.Task6.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* По номеру масти и достоинства карты определить полное название карты.   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Масти: 1 - пики, 2 - трефы, 3 - бубны, 4 - червы                        *");
        Console.WriteLine("* Достоинства: 6..10, 11 - валет, 12 - дама, 13 - король, 14 - туз        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер масти:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер достоинства карты:");
        int k = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((m < 1) || (m > 4) || (k < 6) || (k > 14))
        {
            res = "Введено неверное значение";
        }
        else
        {
            res = ds.FindCardNameAndValue(m, k);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);

        Console.ReadLine();
    }
}