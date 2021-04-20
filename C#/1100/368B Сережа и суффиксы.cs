/*
У Сережи есть массив a, состоящий из n целых чисел a1, a2, ..., an. Мальчику не сидится на месте, и он решил заняться изучением массива. Сережа выписал на листочек m целых чисел l1, l2, ..., lm (1 ≤ li ≤ n). Для каждого числа li он хочет узнать: сколько есть различных чисел среди чисел ali, ali + 1, ..., an?

Сережа выписывал и выписывал нужные элементы массива, но массив был большой, а времени у Сережи мало. Помогите ему, найдите ответ на описанный вопрос для каждого li.


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
            int n = mas[0], m = mas[1];
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = new int[100000];
            int[] count = new int[n], l = new int[m];
            numbers[a[n - 1]] = 1;
            count[n - 1] = 1;
            for(int i = n-2; i >=0; i--)
            {
                if (numbers[a[i]] == 0)
                {
                    numbers[a[i]] = 1;
                    count[i] = count[i + 1] + 1;
                }
                else
                    count[i] = count[i + 1];
            }
            for(int i = 0; i < m; i++)
            {
                l[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
                Console.WriteLine(count[l[i] - 1]);
        }
    }
}