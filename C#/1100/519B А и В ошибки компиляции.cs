/*
A и B готовятся к олимпиадам про программированию.

B очень любит отлаживать свой код. Но перед тем, как запустить решение и начать отладку, код нужно сначала скомпилировать.

Изначально компилятор выдавал n ошибок компиляции, каждая из которых обозначается положительным целым числом. После некоторых усилий, B удалось исправить сначала одну, а потом еще одну ошибку.

Однако, несмотря на то, что B уверен, что исправил две ошибки, он не может понять, какие именно ошибки компиляции исчезли — компилятор языка, на котором пишет B, каждый раз выдает ошибки в новом порядке! B уверен, что в отличие от многих других языков программирования, ошибки компиляции для его языка программирования не зависят друг от друга, т. е. от исправления одной ошибки, множество остальных ошибок не изменяется.

А вы можете помочь B узнать, какие именно две ошибки он исправил?

 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), j = 0;
            int[] er = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(er);
            int[] test;
            for (int i = 0; i < 2; i++)
            {
                test = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array.Sort(test);
                for (j = 0; j < test.Length; j++)
                    if (er[j] != test[j])
                        break;
                Console.WriteLine(er[j]);
                er = test;
            }
        }
    }
}