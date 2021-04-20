/*
Вам задано два целых числа n и k. Ваша задача — определить, можно ли представить n в виде суммы k различных положительных нечетных (не делящихся на 2) целых чисел.

Вам необходимо ответить на t независимых наборов тестовых данных.



 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());
            long[] mas = new long[2];
            for(int i = 0; i < n; i++)
            {
                mas = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                if ((mas[0] % 2 != mas[1] % 2) || (mas[1] * mas[1]) > mas[0])
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }
        }
    }
}