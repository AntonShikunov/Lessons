/*Написать метод подсчета количества цифр числа.
 Шикунов Антон
*/

using System;

namespace Less2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < num.ToString().Length; i++)
            {
                count++;
            }
            Console.WriteLine($"В числе {num} содержится {count} цифр");

        }
    }
}
