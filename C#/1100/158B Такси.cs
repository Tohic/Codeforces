/*
После окончания уроков n групп школьников вышли на улицу и собрались ехать домой к Поликарпу на празднование его дня рождения. Известно, что i-ая группа состоит из si друзей (1 ≤ si ≤ 4), которые не хотят расставаться по пути к Поликарпу. Решено ехать на такси. Каждая машина может вместить не более четырех пассажиров. Какое минимальное количество машин потребуется школьникам, если каждая группа должна целиком находиться в одной из машин такси (но одна машина может вмещать более чем одну группу)?

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
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = new int[] { 0, 0, 0, 0 };
            int count = 0;
            for (int i = 0; i < n; i++)
                numbers[mas[i] - 1]++;
            count = numbers[3];//4
            numbers[3] = 0;

            if (numbers[2] > numbers[0])//3 and 1
            {
                count += numbers[0];
                numbers[2] -= numbers[0];
                count += numbers[2];
                numbers[2] = 0;
                numbers[0] = 0;
            }
            else
            {
                count += numbers[2];
                numbers[0] -= numbers[2];
                numbers[2] = 0;
            }

            int m = Convert.ToInt32(numbers[1] / 2);//2 and 2
            count += m;
            numbers[1] -= 2 * m;

            m = Convert.ToInt32(numbers[0] / 2) * 2 == numbers[0] ? Convert.ToInt32(numbers[0] / 2)
                : Convert.ToInt32(numbers[0] / 2) + 1;//2 and 1
            if (m > numbers[1])
            {
                count += numbers[1];
                numbers[0] -= numbers[1] * 2;
                numbers[1] = 0;
            }
            else
            {
                count += m;
                numbers[1] -= m;
                numbers[0] -= m * 2;
                numbers[0] = numbers[0] > 0 ? numbers[0] : 0;
            }
            m = Convert.ToInt32(numbers[0] / 4) * 4 == numbers[0] ? Convert.ToInt32(numbers[0] / 4)
                : Convert.ToInt32(numbers[0] / 4) + 1;
            count += m;
            numbers[0] -= m * 4;
            numbers[0] = numbers[0] > 0 ? numbers[0] : 0;
            for (int i = 0; i < 4; i++)
                count += numbers[i];
            Console.WriteLine(count);
        }
    }
}