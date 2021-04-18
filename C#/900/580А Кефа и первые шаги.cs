/*
Кефа решил подзаработать денег, занимаясь различной деятельностью в интернете на протяжении ровно n дней. Он знает, что в i-й день (1 ≤ i ≤ n) он заработает ai монет. Кефа любит прогресс, поэтому он хочет узнать длину максимального неубывающего подотрезка в последовательности ai. Напомним, что подотрезок последовательности — это её непрерывный фрагмент. Подотрезок чисел называется неубывающим, если числа в нём следуют в порядке неубывания.

Помогите Кефе справиться с этой задачей!

 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            ulong[] mas = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();
            int maxl = 0, count = 1;
            for(int i = 1; i < n; i++)
            {
                if (mas[i] >= mas[i - 1])
                    count++;
                else
                {
                    if (maxl < count)
                        maxl = count;
                    count = 1;
                }
            }
            if (maxl < count)
                maxl = count;
            Console.WriteLine(maxl);
        }
    }
}