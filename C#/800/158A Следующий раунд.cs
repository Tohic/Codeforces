/*
 «Участник выходит в следующий раунд соревнований, если он набрал не меньше баллов, чем участник, занявший k-е место, при условии, что набранное им число баллов строго положительно...» — выдержка из правил соревнований.

Всего в соревновании было n участников (n ≥ k), и вам уже известны их баллы. Определите, сколько участников выйдет в следующий раунд.
 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(st[0]);
            int k = int.Parse(st[1]);
            int count = 0;
            int[] results = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
                if (results[i] >= results[k - 1] && results[i] != 0)
                    count++;
            Console.WriteLine(count);
        }
    }
}