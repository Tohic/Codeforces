/*
Солдат хочет купить w бананов в магазине. Ему надо заплатить k долларов за первый банан, 2k долларов — за второй и так далее (иными словами, за i-й банан надо заплатить i·k долларов).

У него есть n долларов. Сколько долларов ему придется одолжить у однополчанина, чтобы купить w бананов?
 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 1; i <= numbers[2]; i++)
                count += numbers[0] * i;
            count -= numbers[1];
            if (count > 0)
                Console.WriteLine(count);
            else
                Console.WriteLine(0);
        }
    }
}