/*
 На столе в ряд выложены n камней, каждый из которых может быть красного, зеленого или синего цвета. Посчитайте, какое минимальное количество камней нужно убрать со стола, чтобы любые два соседних камня имели разные цвета. Камни в ряду считаются соседними, если между ними нет других камней.
*/
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string st = Console.ReadLine();
            for(int i = 1; i < n; i++)
            {
                if (st[i] == st[i - 1])
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}