/*
У Shubham есть массив a размера n, и он хочет выбрать из него ровно x элементов так, чтобы их сумма была нечетной. Эти элементы не обязаны быть последовательными. Элементы массива не обязательно различны.

Скажите ему, может ли он сделать это.

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
            for(int i = 0; i < n; i++)
            {
                count = 0;
                int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < mas[0]; j++)
                    if ((num[j] & 1) == 1)
                        count++;
                if (count == 0 || mas[0] == mas[1] && (count & 1) == 0 || count == mas[0] && (mas[1] & 1) == 0)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }     
        }
    }
}