/*
Петя любит счастливые числа. Всем известно, что счастливыми являются положительные целые числа, в десятичной записи которых содержатся только счастливые цифры 4 и 7. Например, числа 47, 744, 4 являются счастливыми, а 5, 17, 467 — не являются.

Петя называет число почти счастливым, если оно делится без остатка на какое-либо счастливое число. Помогите ему узнать, является ли заданное число n почти счастливым?

 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 4, 7, 47, 74, 447, 474, 477, 744, 747, 774};
            int n = int.Parse(Console.ReadLine()), i = 0;
            bool flag = false;
            while(flag == false && i < data.Length)
            {
                if (n % data[i++] == 0)
                    flag = true;
            }
            Console.WriteLine( flag ? "YES" : "NO");
        }
    }
}