/*
Капитализация — это запись слова, в которой первая буква слова записывается как прописная буква. Ваша задача, вывести капитализацию заданного слова.

Обратите внимание, что в капитализации все буквы слова кроме первой остаются не измененными.
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
            string s1 = st.ToUpper();
            st = st.Substring(1, st.Length-1);
            Console.WriteLine(s1[0]+st);
        }
    }
}