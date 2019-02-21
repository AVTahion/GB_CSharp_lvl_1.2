using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  6)  *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число,
        которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
    7)  a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */
 
namespace Task_6
{
    class Program
    {
        /// <summary>
        /// Метод определяет делиться ли передаваемое число на сумму своих цифр.
        /// </summary>
        /// <param name="x">Проверяемое число</param>
        /// <returns>True если делиться без остатка</returns>
        static bool GoodNumber(int x)
        {
            bool res = false;
            int sum = 0;
            int y = x;
            do
            {
                sum += x % 10;
                x /= 10;
            } while (x != 0);
            if (y % sum == 0) res = true;
            return res;
        }

        /// <summary>
        /// Метод подсчитывает кол-во "Хороших" чисел в заданном диапазоне
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private static int AmountOfGoodNumbers(int min, int max)
        {
            int amount = 0;
            for (int i = min; i <= max; i++)
            {
                if (GoodNumber(i)) amount++;
            }
            return amount;
        }

        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(AmountOfGoodNumbers(1, 1000000000));
            Console.WriteLine($"Время выполнения программы: {DateTime.Now - time}"); //~2.34 мин
            Console.ReadKey();
        }
    }
}
