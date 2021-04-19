/*
Лев Илья хочет помочь всем своим друзьям со сдачей экзаменов. Чтобы сдать экзамен по информатике нужно решить следующую задачу.

Даны строка s = s1s2... sn (n — длина строки), состоящая только из символов «.» и «#», и m запросов. Каждый запрос описывается парой целых чисел li, ri (1 ≤ li < ri ≤ n). Ответ на запрос li, ri — это количество таких целых чисел i (li ≤ i < ri), что si = si + 1.

Лев Илья хочет помочь друзьям, но кто же поможет ему. Помогите Льву Илье, решите задачу.

 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            int[] num = new int[st.Length];
            for (int i = 1; i < st.Length; i++)
                if (st[i] == st[i - 1])
                    num[i] = num[i - 1] + 1;
                else
                    num[i] = num[i - 1];
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[2];
            for(int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(num[numbers[1]-1] - num[numbers[0]-1]);
            }
        }
    }
}