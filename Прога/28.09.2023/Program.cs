using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._09._2023
{
    internal class Program
    {
        enum DayOfWeek // к 4 заданию
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность\r\nупорядоченной по возрастанию.");
            Console.WriteLine("Введите последовательность из 10 чисел:\t");
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                string s = Console.ReadLine();
                int n;
                bool check = int.TryParse( s, out n);
                while (check == false)
                {
                    Console.WriteLine("Вы вели не число. Введите число:");
                    s = Console.ReadLine();
                    check = int.TryParse( s, out n);
                }
                array[i] = n;    
            }
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);    
            }
            Console.WriteLine("Упорядочность:");
            int I = 0;
            while (I < 10)
            {
                I++;
                if (I == 9)
                {
                    Console.WriteLine("Последовательность возрастает");
                    break;
                }
                else if (array[I] >= array[I+1])
                {
                    Console.WriteLine($"Порядковый номер числа, которое нарушило последовательность: {I+1}");
                    break;
                }
            }

            Console.WriteLine("2. Игральным картам условно присвоены следующие порядковые номера в зависимости от\r\nих достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. По заданному номеру карты k (6 <=k <= 14) определить достоинство\r\nсоответствующей карты.");
            Console.WriteLine("Введите номер карты(от 6 до 14)");
            try
            {
                int card = int.Parse(Console.ReadLine());
                if (card >= 6 && card <= 14)
                {
                    switch (card)
                    {
                        case 6:
                            Console.WriteLine("Шестерка");
                            break;
                        case 7:
                            Console.WriteLine("Семерка");
                            break;
                        case 8:
                            Console.WriteLine("Восьмерка");
                            break;
                        case 9:
                            Console.WriteLine("Девятка");
                            break;
                        case 10:
                            Console.WriteLine("Десятка");
                            break;
                        case 11:
                            Console.WriteLine("Валет");
                            break;
                        case 12:
                            Console.WriteLine("Дама");
                            break;
                        case 13:
                            Console.WriteLine("Король");
                            break;
                        case 14:
                            Console.WriteLine("Туз");
                            break;
                    }              
                }
                else 
                {
                    Console.WriteLine("Вы ввели число не принадлежащие отрезку [6;14]");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
            }

            Console.WriteLine("3. Напишите программу, которая принимает на входе строку и производит выходные\r\nданные в соответствии со следующей таблицей");
            Console.WriteLine("Введите слово: ");
            string word = Console.ReadLine();
            string val = "";
            foreach (var ch in word)
                if (char.IsUpper(ch))
                    val += char.ToLower(ch);
                else 
                    val += ch;
            val = Convert.ToString(val);
            switch (val)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politican":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default: 
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine("4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,\r\n...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).");
            Console.WriteLine("Введите порядковый номер недели(1,2, ...,7):");
            byte ordinal = byte.Parse(Console.ReadLine());
            switch (ordinal)
            {
                case 1:
                    Console.WriteLine((DayOfWeek)1);
                    break;
                case 2:
                    Console.WriteLine((DayOfWeek)2);
                    break;
                case 3:
                    Console.WriteLine((DayOfWeek)3);
                    break;
                case 4:
                    Console.WriteLine((DayOfWeek)4);
                    break;
                case 5:
                    Console.WriteLine((DayOfWeek)5);
                    break;
                case 6:
                    Console.WriteLine((DayOfWeek)6);
                    break;
                case 7:
                    Console.WriteLine((DayOfWeek)7);
                    break;
                default:
                    Console.WriteLine("Число не принадлежит [1;7]");
                    break;
            } 

            Console.WriteLine("5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента\r\n\"Hello Kitty\" или \"Barbie doll\" необходимо положить их в “сумку”, т.е. прибавить к\r\nрезультату. Вывести на экран сколько кукол в “сумке”.");
            Console.WriteLine("Введите кол-во элементов массива:");
            int size = int.Parse(Console.ReadLine());
            string[] arrString;
            arrString = new string[size];
            Console.WriteLine($"Введите элементы массива в количестве {size}:");
            for (int i = 0; i < arrString.Length; i++)               
                arrString[i] =Convert.ToString(Console.ReadLine());
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < arrString.Length; i++)
            {
                Console.WriteLine(arrString[i]);
            }
            int sum = 0; 
            foreach(string selected in arrString) 
            {
                switch(selected)
                {
                    case "Hello Kitty":
                        sum += 1;
                        break;
                    case "Barbie doll":
                        sum += 1;
                        break;
                }
            }
            Console.WriteLine($"Кол-в кукол в сумке:{sum}");

            Console.ReadLine();
 
        }
    }
}
