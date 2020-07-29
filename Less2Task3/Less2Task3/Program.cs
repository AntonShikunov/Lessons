/* С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 
Шикунов Антон
*/

using System;

namespace Less2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sum = 0;
            do
            {
                Console.WriteLine("Введи число: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 1)
                sum += num;
            }
            while (num != 0);

            Console.WriteLine($"Сумма нечётный чисел равна {sum}");
        }
    }
}
