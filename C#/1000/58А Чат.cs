/*
Совсем недавно Вася научился печатать на клавиатуре и выходить в интернет. Он сразу же зашел в чат и решил поздороваться со всеми. Вася напечатал слово s. Считается, что у Васи получилось поздороваться, если из напечатанного слова можно удалить некоторые буквы так, чтобы получилось слово "hello". Например, если Вася напечатал слово "ahhellllloou", считается, что он поздоровался, а если он напечатал "hlelo", считается, что Васю не поняли, и ему не удалось поздороваться. По заданному слову s определите, удалось ли Васе поздороваться.

 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "hello";
            string st = Console.ReadLine();
            int k = 0;
            for(int i = 0; i < st.Length; i++)
            {
                if (st[i] == test[k])
                {
                    k++;
                    if (k == test.Length)
                        break;
                }
            }
            Console.WriteLine( k == test.Length ? "YES" : "NO" );
        }
    }
}