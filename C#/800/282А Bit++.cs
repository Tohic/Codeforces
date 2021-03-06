/*
 Классический язык программирования в Битландии — Bit++. Этот язык очень необычный и сложный!

Особенность языка Bit++ состоит в том, что в нем ровно одна переменная, которая называется x. Также в этом языке есть две операции:

Операция ++ увеличивает значение, хранящееся в переменной x на 1.
Операция -- уменьшает значение, хранящееся в переменной x на 1.
Предложение в языке Bit++ — это последовательность, состоящая из ровно одной операции и ровно одной переменной x. Предложение записывается без пробелов, то есть может содержать только символы: «+», «-», «X». Выполнить предложение, значит выполнить операцию, которая содержится в предложении.

Программа на языке Bit++ — это последовательность предложений, каждое из которых требуется выполнить. Выполнить программу, значит выполнить все ее предложения.

Вам задана программа на языке Bit++. Перед выполнением программы в переменной x хранится значение 0. Выполните программу и выведите значение, которое будет храниться в переменной x после выполнения программы.
 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                string st = Console.ReadLine();
                if (st[1] == '+')
                    result++;
                else
                    result--;
            }
            Console.WriteLine(result);
        }
    }
}