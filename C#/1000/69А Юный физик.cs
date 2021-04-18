/*
В одной школе в 11 классе учится мальчик Вася. Как-то раз Вася решил посмотреть матч своей любимой хоккейной команды. А поскольку мальчик очень любит хоккей, даже больше, чем физику, он забыл сделать уроки. В частности, забыл сделать задачки по физике. На следующий день учитель очень разозлился на Васю, и решил его проучить. Он дал нерадивому ученику, казалось бы, простую задачку: дано покоящееся тело в пространстве, и даны силы, действующие на него. Тело можно считать материальной точкой с координатами (0; 0; 0). Васе нужно было ответить, находится ли оно в равновесии. «Ерунда!» — подумал Вася, нужно лишь проверить, что сумма всех векторов равна 0, и принялся решать задачу. Но впоследствии оказалось, что этих сил может быть очень-очень много, и Вася не справится без вашей помощи. Помогите ему. Напишите программу, которая определяет по заданным векторам сил, покоится тело или движется.

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
            int[] result = new int[] { 0, 0, 0 };
            int[] mas;
            for (int i = 0; i < n; i++)
            {
                mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                result[0] += mas[0];
                result[1] += mas[1];
                result[2] += mas[2];
            }
            Console.WriteLine( result[0] == 0 && result[1] == 0 && result[2] == 0 ? "YES" : "NO" );
        }
    }
}