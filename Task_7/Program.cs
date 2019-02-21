using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  7)  a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */

namespace Task_7
{
    class Program
    {
        /// <summary>
        /// Метод выводит на экран числа от a до b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void AToB(int a, int b)
        {
            if (a <= b)
            {
                if (a == b) Console.WriteLine(b);
                else
                {
                    Console.WriteLine(a);
                    a++;
                    AToB(a, b);
                }
            }
        }

        /// <summary>
        /// Метод считает сумму чисел от a до b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum"></param>
        static void AToBSum (int a, int b, ref int sum)
        {
            sum = sum + a;
            
            if (a > b) sum = -1;
            if (a == b) return;
            else AToBSum(a + 1, b, ref sum);
        }

        static void Main(string[] args)
        {
            AToB(2, 8);
            Console.ReadKey();
            Console.WriteLine();
            int sum = 0;
            AToBSum(2, 10, ref sum);
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
