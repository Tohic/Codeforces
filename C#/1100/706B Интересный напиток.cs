/*
Рабочий Василий очень любит отдыхать после работы, поэтому его часто можно встретить в каком-нибудь баре. Как и все программисты, Василий очень любит напиток «Пикола», который продаётся в n различных магазинах города. Известно, что в i-м магазине бутылка напитка стоит xi монет.

Василий планирует покупать одну бутылку своего любимого напитка на протяжении q дней. Он знает, что в i-й день у него с собой будет mi монет, и теперь он хочет для каждого из дней узнать, в каком количестве магазинов он сможет купить одну бутылочку Пиколы.

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
            int num = 0;
            int m = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > num)
                    num = mas[i];
            }
            int[] ar = new int[num];
            for (int i = 0; i < mas.Length; i++)
                ar[mas[i] - 1] += 1;
            for (int i = 1; i < num; i++)
                ar[i] += ar[i - 1];
            int nnn = int.Parse(Console.ReadLine());
            for (int i = 0; i < nnn; i++)
            {
                m = int.Parse(Console.ReadLine());
                if (m > num)
                    Console.WriteLine(ar[num - 1]);
                else
                    Console.WriteLine(ar[m - 1]);
            }
        }
    }
}