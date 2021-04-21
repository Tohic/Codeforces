/*
Ваня идет поздней ночью по прямолинейной улице длины l, которая освещается n фонарями. Введём систему координат, в которой начало улицы соответствует точке 0, а её конец — точке l. Тогда i-й фонарь находится в точке ai. Фонарь освещает все точки улицы, которые находятся от него на расстоянии не больше d, где d — некоторое положительное число, общее для всех фонарей.

Ваня хочет узнать, какой минимальный радиус освещения d должен быть у фонарей, чтобы вся улица была освещена.

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
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(num);
            double max = (num[0]) > (mas[1] - num[mas[0]-1]) ? num[0] : mas[1] - num[mas[0]-1];
            for (int i = 1; i < mas[0]; i++)
                if (max < Convert.ToDouble(num[i] - num[i - 1])/2)
                    max = Convert.ToDouble(num[i] - num[i - 1]) / 2;
            Console.WriteLine(max);
        }
    }
}