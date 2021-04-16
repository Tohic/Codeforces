/*
Перед Вами матрица размера 5 × 5, состоящая из 24-x нулей и единственной единицы. Строки матрицы пронумеруем числами от 1 до 5 сверху вниз, столбцы матрицы пронумеруем числами от 1 до 5 слева направо. За один ход разрешается применить к матрице одно из двух следующих преобразований:

Поменять местами две соседние строки матрицы, то есть строки с номерами i и i + 1 для некоторого целого i (1 ≤ i < 5).
Поменять местами два соседних столбца матрицы, то есть столбцы с номерами j и j + 1 для некоторого целого j (1 ≤ j < 5).
Вы считаете, что матрица будет выглядеть красиво, если единственная единица этой матрицы будет находиться в ее центре (в клетке, которая находится на пересечении третьей строки и третьего столбца). Посчитайте, какое минимальное количество ходов потребуется, чтобы сделать матрицу красивой.
 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 0; i < 5; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j = 0; j < 5; j++)
                {
                    if (numbers[j] == 1)
                        count = Math.Abs(j - 2) + Math.Abs(i - 2);
                }
            }
            Console.WriteLine(count);
        }
    }
}