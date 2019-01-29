using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1) Написать метод, возвращающий минимальное из трёх чисел.
    2) Написать метод подсчета количества цифр числа.
    3) С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.
    4) Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина,
       если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки
       логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
       С помощью цикла do while ограничить ввод пароля тремя попытками.
    5)  а - Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        б - *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    6) *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
    7)  a - Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        б - *Разработать рекурсивный метод, который считает сумму чисел от a до b.

    Кушмилов Александр.
*/

namespace GB_CSharp_lvl_1._2
{
    class Program
    {
        // Задание №1

        /// <summary>
        /// Метод возвращающий минимальное из трех чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int MinOfThree(int a, int b, int c)
        {
            int min = a < b ? a : b;
            min = min < c ? min : c;
            return min;
        }

        // Задание №2

        /// <summary>
        /// Метод подсчитывающий количество цифр числа.
        /// </summary>
        /// <param name="x"></param>
        static void NmberOfDigits (long x)
        {
            int NOD = 0;
            while (x != 0)
            {
                x = x / 10;
                NOD++;
            }
            Console.WriteLine(NOD);
        }

        /// <summary>
        /// Метод проверяет является ли число положительным нечетным.
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        static bool OddPositiveCheck(int X)
        {
            return (X % 2 != 0 && X > 0) ? true : false;
        }

        static void Main(string[] args)
        {
            // Задание №3

            int sum = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            while (x != 0)
            {
                if (OddPositiveCheck(x)) sum += x;
                x = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
