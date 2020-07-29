/*Написать метод, возвращающий минимальное из трёх чисел.

Шикунов Антон
*/

using System;

namespace Less2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(0, 100);
            int b = rand.Next(0, 100);
            int c = rand.Next(0, 100);

            Console.WriteLine($"Число а = {a}, число b = {b}, число с = {c}");
            
            if (a < b && a < c)
            {
                Console.WriteLine($"Минимальное число: {a}");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"Минимальное число: {b}");
            }
            else
            {
                Console.WriteLine($"Минимальное число: {c}");
            }

        }
    }
}
