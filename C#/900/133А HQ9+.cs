/*
HQ9+ — шуточный язык программирования, состоящий всего из четырех односимвольных команд:

«H» печатает «Hello, World!»,
«Q» печатает исходный код самой программы,
«9» печатает текст песни «99 бутылок пива»,
«+» увеличивает на единицу значение внутреннего счетчика.
Команды «H» и «Q» воспринимаются только в верхнем регистре. Все символы программы, не являющиеся командами, игнорируются.

Вам дана программа на HQ9+. Определите, будет ли что-то напечатано в результате ее выполнения
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
            if (st.Contains('H') || st.Contains('Q') || st.Contains('9'))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}