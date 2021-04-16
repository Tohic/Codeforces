/*
Маленький Петя очень любит подарки. Его мама подарила ему на день рождения две строки равной длины, состоящие из больших и маленьких букв латинского алфавита. Теперь Петя хочет сравнить эти строки лексикографически. При этом регистр букв значения не имеет, то есть большая буква считается эквивалентной соответствующей маленькой букве. Помогите Пете выполнить сравнение.
 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine(string.Compare(s1.ToLower(),s2.ToLower()));
        }
    }
}