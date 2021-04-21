/*
Совсем недавно Аня начала использовать метро как средство передвижения по городу. Известно, что билет на один проезд в метро стоит a рублей. Также Аня узнала, что можно купить абонемент на m проездов за b рублей (абонемент можно покупать несколько раз). Аня подсчитала, что в ближайшее время ей придется воспользоваться метрополитеном n раз. Помогите Ане, подскажите ей, какую минимальную сумму денег ей придется потратить, чтобы совершить n поездок?

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
            int result = 0, m = 0;
            if (mas[2] > (mas[3] / mas[1]))
            {
                m = mas[0] / mas[1];
                result = m * mas[3];
                if (m != mas[0])
                    if ((mas[0] - m * mas[1]) * mas[2] > mas[3])
                        result += mas[3];
                    else
                        result += (mas[0] - m * mas[1]) * mas[2];
            }
            else
                result = mas[2] * mas[0];
            Console.WriteLine(result);
        }
    }
}