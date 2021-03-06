/*
Начинающий математик Ксения учится в третьем классе. Сейчас в школе она проходит операцию сложения.

Учитель записал на доске сумму нескольких чисел, которую требуется посчитать. Чтобы было проще считать, в сумме используются только числа 1, 2 и 3. Но и этого Ксении мало. Ксения только учится считать, и поэтому она может посчитать сумму, только если слагаемые в сумме идут в порядке неубывания. Например, сумму 1+3+2+1 она посчитать не может, а суммы 1+1+2 и 3+3 может.

Вам задана сумма, которая записана на доске. Переставьте слагаемые и выведите ее в виде, в котором Ксения сможет посчитать сумму.
 */
using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split('+').Select(int.Parse).ToArray();
            Array.Sort(numbers);
            Console.WriteLine(string.Join("+", numbers));
        }
    }
}