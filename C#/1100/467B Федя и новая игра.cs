/*
Как только вы помогли Юре с Лешей заселиться, они пошли помогать своему другу Феде играть в новую компьютерную игру «Call of Soldiers 3».

Всего в игре есть (m + 1) игроков и n видов солдат. Игроки «Call of Soldiers 3» пронумерованы от 1 до (m + 1), а виды солдат пронумерованы от 0 до n - 1. У каждого игрока есть армия, армия i-го игрока характеризуется целым неотрицательным числом xi. Рассмотрим битовое представление числа xi: если j-й бит числа xi равен единице, то в армии i-го игрока есть солдаты j-го вида.

Федя — игрок с номером m + 1. Федя считает, что два игрока могут дружить, если их армии отличаются не более чем на k видов солдат (другими словами, битовые представления соответствующих чисел различаются не более чем в k битах). Помогите Феде посчитать, сколько игроков могут с ним дружить.

 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] num = new int[mas[1] + 1];
            for (int i = 0; i < mas[1] + 1; i++)
                num[i] = int.Parse(Console.ReadLine());
            int buf = 0, count, result = 0;
            for(int i = 0; i < mas[1]; i++)
            {
                count = 0;
                buf = num[i] ^ num[mas[1]];
                while (buf != 0)
                {
                    count += buf % 2;
                    buf /= 2;
                }

                if(count <= mas[2])
                    result++;
            }
            Console.WriteLine(result);
        }
    }
}