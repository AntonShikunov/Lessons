/* а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

Шикунов Антон
*/

using System;

namespace Less2Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой рост: ");
            double hight = Convert.ToDouble(Console.ReadLine());
            hight /= 100; // перевод в метры
            Console.WriteLine("Введите свой вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double imt = (weight / (hight * hight));
            Console.WriteLine("Ваш индекс массы тела: {0:f2}", imt);
            if (imt < 19)
            {
                Console.WriteLine($"У вас дефицит массы. Необходимо набрать {19 - imt:f2} кг.");
            }
            else if (imt >= 19 && imt < 24)
            {
                Console.WriteLine("Всё отлично!");
            }
            else
            {
                Console.WriteLine($"Нужно худеть! Необходимо сбросить {imt - 24:f2} кг.");
            }
        }
    }
}
