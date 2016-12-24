using System;
using System.Collections.Generic;



namespace Kaspersky_task2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Задаем лист с числами и выводим на экран:
            List<int> digits = new List<int> { 1, -1, 8,9, 1,2,3,4,5,6 };

            Console.WriteLine("Ваши коллекция чисел:");
            foreach (var digit in digits)
            {
               Console.Write(digit.ToString() + " ");
            }

            Console.WriteLine();

            ConsoleKeyInfo cki;

            //Программа будет рабоать до тех пор пока на нажмем ESC - так лучше тестить ;)
            while (true)
            {
                //Задаем значение суммы стандартным вводом:
                Console.Write("Введите заданое число X: ");
                var x = int.Parse(Console.ReadLine());

                //В методе FindPairs реализован алгоритм поиска нужных пар чисел и их стандартный вывод
                bool flag = FindPairs(x, digits);

                if (flag == true)
                {
                    Console.WriteLine("Готово! Нажмите Enter для выхода");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    Console.WriteLine("Задача не имеет ответа. Введите Enter для задания новой суммы или нажмите ESC...");
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Escape)
                    break;

                }
            }
        }

        static bool FindPairs(int x, List<int> digits, bool flag = false)
        {
            //Писать свою сортировкe я уж не стал. Хотя догадываюсь, что задача на алгоритмы ;)
            digits.Sort();
            int first = 0;
            int last = digits.Count - 1;

            while (first < last)
            {
                int sum = digits[first] + digits[last];
                if (sum == x)
                {
                    flag = true;
                    Console.WriteLine(digits[first] + " " + digits[last]);
                    first++;
                    last--;
                }
                else
                {
                    if (sum < x) first++;
                    else last--;
                }
            }


            return flag;
        }

        

    }
}
