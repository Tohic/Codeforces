/*
Как-то раз Дима и Леша поспорили о цене и качестве ноутбуков. Дима считает, что чем дороже ноутбук, тем он лучше. Леша говорит, что это не так. Леша считает, что существуют два таких ноутбука, что цена первого меньше, чем цена второго, но первый качественнее второго.

Ваша задача — проверить гипотезу Леши. Заданы характеристики n ноутбуков. Выясните, существуют ли два таких ноутбука, что цена первого строго меньше, чем цена второго, но первый строго качественнее второго.

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
            int[] a = new int[n], b = new int[n], mas = new int[2];
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                a[i] = mas[0];
                b[i] = mas[1];
                if (a[i] == b[i])
                    flag++;
            }
            Console.WriteLine(flag == n ? "Poor Alex" : "Happy Alex");
        }
    }
}