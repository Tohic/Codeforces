/*
Эмускальду надо построить забор вокруг фермы, но вот самому это делать ему лень. Так что юноша приобрел робота-заборостройщика.

Эмускальду хочется, чтобы забор представлял собой правильный многоугольник. К сожалению, его робот строит забор, двигаясь по единственному пути. При этом робот может соединять стороны забора только под заданным углом a.

Сможет ли робот построить забор, который хочет Эмускальд? Иными словами, существует ли правильный многоугольник с углами, равными a?

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
            double m = 0;
            for (int i = 0; i < n; i++)
            {
                m = double.Parse(Console.ReadLine());
                Console.WriteLine(((2 * 180) / (180 - m) - Convert.ToInt32((2 * 180) / (180 - m))) == 0
                    ? "YES" : "NO");
            }
        }
    }
}