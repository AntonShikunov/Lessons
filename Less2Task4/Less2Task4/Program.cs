/*Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

Шикунов Антон

*/

using System;
using System.Net.NetworkInformation;

namespace Less2Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "root";
            string password = "GeekBrains";
            string log, pass;
            int count = 3; // количество попыток
            do
            {
                Console.WriteLine("Введите логин: ");
                log = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите пароль: ");
                pass = Convert.ToString(Console.ReadLine());
                if (log != login || pass != password)
                {
                    count--;
                }
            }
            while ((count != 0) && (log != login || pass != password));

            if (count == 0)
            {
                Console.WriteLine("Три попытки закончились");
            }
            else
            {
                Console.WriteLine("Успешная авторизация");
            }
        }
    }
}
