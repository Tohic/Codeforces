using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            long t = long.Parse(Console.ReadLine());
            long n;
            long count = 0, result = 0;
            for (int k = 0; k < t; k++)
            {
                n = long.Parse(Console.ReadLine());
                long[] mas = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                count = mas[0];
                result = 0;
                flag = mas[0] > 0 ? true : false;
                for (int i = 0; i < n; i++)
                {
                    if (flag)
                    {
                        if (mas[i] > 0)
                        {
                            if (count < mas[i])
                                count = mas[i];
                        }
                        else
                        {
                            result += count;
                            count = mas[i];
                            flag = false;
                        }
                    }
                    else
                    {
                        if (mas[i] < 0)
                        {
                            if (count < mas[i])
                                count = mas[i];
                        }
                        else
                        {
                            result += count;
                            count = mas[i];
                            flag = true;
                        }
                    }
                }
                result += count;
                Console.WriteLine(result);
            }

        }
    }
}