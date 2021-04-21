/*
По случаю 100500-летия Берляндского государственного университета совсем скоро состоится бал! Уже n юношей и m девушек во всю репетируют вальс, менуэт, полонез и кадриль.

Известно, что на бал будут приглашены несколько пар юноша-девушка, причем уровень умений танцевать партнеров в каждой паре должен отличаться не более чем на единицу.

Для каждого юноши известен уровень его умения танцевать. Аналогично, для каждой девушки известен уровень ее умения танцевать. Напишите программу, которая определит наибольшее количество пар, которое можно образовать из n юношей и m девушек.


 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] masw = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int b = int.Parse(Console.ReadLine());
            int[] masm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(masw);
            Array.Sort(masm);
            int result = 0;
            for(int i = 0; i < a; i++)
                for(int j = 0; j < b; j++)
                    if (Math.Abs(masw[i] - masm[j]) <= 1)
                    {
                        result++;
                        /*Console.WriteLine(masw[i]);
                        Console.WriteLine(masm[j]);*/
                        masw[i] = 200;
                        masm[j] = 200;
                        break;
                    }
            Console.WriteLine(result);
        }
    }
}