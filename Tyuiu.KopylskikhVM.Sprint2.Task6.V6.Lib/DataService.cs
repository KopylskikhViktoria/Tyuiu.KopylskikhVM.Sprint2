using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KopylskikhVM.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string suit = value1 switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "черв",
                _ => throw new ArgumentException("Неверный номер масти")
            };

            string value = value2 switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => throw new ArgumentException("Неверный номер достоинства карты")
            };

            return value + " " + suit;
        }
    }
}