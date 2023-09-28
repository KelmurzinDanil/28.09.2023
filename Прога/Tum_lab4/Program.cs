using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня\r\nв году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9\r\nфевраля (високосный год не учитывать).");
                Console.WriteLine("Введите ваш год");
                int year = int.Parse(Console.ReadLine());
                DateTime date = new DateTime(year, 1, 1);
                Console.WriteLine("Введите номер дня");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine(date.AddDays(day));

                Console.WriteLine("Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного\r\nпользователем. Если число меньше 1 или больше 365, программа должна вырабатывать\r\nисключение, и выдавать на экран сообщение.");
                Console.WriteLine("Введите ваш год");
                int year1 = int.Parse(Console.ReadLine());
                DateTime date1 = new DateTime(year1, 1, 1);
                Console.WriteLine("Введите номер дня");
                int day1 = int.Parse(Console.ReadLine());
                if (day1 >= 1 && day1 <= 365)
                {
                    Console.WriteLine(date1.AddDays(day1));
                }
                else
                {
                    Console.WriteLine("Столько дней в году не бывает");
                }

                Console.WriteLine("Изменить программу из упражнений 4.1 и 4.2 так, чтобы она\r\nучитывала год (високосный или нет). Год вводится с экрана.");
                Console.WriteLine("Введите ваш год");
                int year2 = int.Parse(Console.ReadLine());
                DateTime date2 = new DateTime(year2, 1, 1);
                if (year2 % 4 == 0 && year2 % 100 != 0 || year2 % 400 == 0)
                {
                    Console.WriteLine("Год високосный");
                    Console.WriteLine("Введите номер дня");
                    int day2 = int.Parse(Console.ReadLine());
                    if (day2 >= 1 && day2 <= 365)
                    {
                        Console.WriteLine(date2.AddDays(day2));
                    }
                    else if (day2 == 366)
                    {
                        Console.WriteLine($"29.02.{year2}");
                    }
                    else
                    {
                        Console.WriteLine("Столько дней в високосном году не бывает");
                    }
                }
                else
                {
                    Console.WriteLine("Год обычный");
                    Console.WriteLine("Введите номер дня");
                    int day2 = int.Parse(Console.ReadLine());
                    if (day2 >= 1 && day2 <= 365)
                    {
                        Console.WriteLine(date2.AddDays(day2));
                    }
                    else
                    {
                        Console.WriteLine("Столько дней в году не бывает");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
