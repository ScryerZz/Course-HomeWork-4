using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_HomeWork_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                uint oddNumbersCount = 0;
                uint evenNumbersCount = 0;
                int oddNumbersSum = 0;
                int evenNumbersSum = 0;
                int currentValue;
                int limit;

                try
                {
                    Console.WriteLine("Введите первое число диапазона:");
                    currentValue = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите последнее число диапазона:");
                    limit = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Было введено некорректное число!");
                    Console.WriteLine("Нажмите Enter чтобы очистить консоль");
                    Console.ReadLine();
                    continue;
                }

                while (currentValue <= limit)
                {
                    if (currentValue % 2 == 0)
                    {
                        evenNumbersCount++;
                        evenNumbersSum += currentValue;
                    }
                    else if (currentValue % 2 != 0)
                    {
                        oddNumbersCount++;
                        oddNumbersSum += currentValue;
                    }
                    else
                    {
                        Console.WriteLine("Неизвестная ошибка!");
                    }
                    currentValue++;
                }

                Console.WriteLine($"Количество нечетных чисел: {oddNumbersCount}");
                Console.WriteLine($"Количество четных чисел: {evenNumbersCount}");
                Console.WriteLine($"Сумма нечетных чисел: {oddNumbersSum}");
                Console.WriteLine($"Сумма четных чисел: {evenNumbersSum}");

                Console.WriteLine("Нажмите Enter чтобы очистить консоль");
                Console.ReadLine();
            }
        }
    }
}
