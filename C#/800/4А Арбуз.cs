using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
             for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (name.Length > 12) 
                    Console.WriteLine(name[0] + Convert.ToString(name.Length - 2) + name[name.Length * 1]);
                else
                    Console.WriteLine(name);
            }
        }
    }
}
