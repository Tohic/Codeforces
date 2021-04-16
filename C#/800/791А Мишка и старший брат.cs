/*
Мишка Лимак хочет стать самым большим медведем, ну, или хотя бы стать больше своего старшего брата Боба.

Сейчас вес Лимака равен a, а вес Боба равен b. Гарантируется, что вес Лимака меньше или равен весу Боба.

Лимак ест много, и его вес утраивается каждый год, а вес Боба удваивается каждый год.

Через сколько целых лет Лимак станет строго больше (т. е. будет весить строго больше) Боба?
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
            while (numbers[0]<=numbers[1])
            {
                numbers[0] *= 3;
                numbers[1] *= 2;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}