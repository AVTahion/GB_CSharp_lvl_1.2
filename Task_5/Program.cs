using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  5)  а - Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        б - *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    
    Александр Кушмилов
*/

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш Рост:");
            string userHeight = Console.ReadLine();
            Console.WriteLine("Введите Ваш Вес:");
            string userWeight = Console.ReadLine();
            double iMT = IMT(userHeight, userWeight);
            Console.WriteLine($"Ваш индекс массы тела (ИМТ): {iMT}");
            // норма ИМТ 18,5 — 24,99
            double x;
            if (iMT > 24.99)
            {
                Console.WriteLine("Вам нужно похудеть");
                x = Convert.ToInt16(userWeight) - 24.99 * Math.Pow(Convert.ToDouble(userHeight) / 100, 2);
                Console.WriteLine($"Вам нужно сбросить {x} кг.");
            }
            else if (iMT < 18.5)
            {
                Console.WriteLine("Вам нужно набрать вес");
                x = 18.5 * Math.Pow(Convert.ToDouble(userHeight) / 100, 2) - Convert.ToInt16(userWeight);
                Console.WriteLine($"Вам нужно набрать {x} кг.");
            }
            else
            {
                Console.WriteLine("Ваш вес в норме");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Метод расчитывает индекс массы тела.
        /// </summary>
        /// <param name="userHeight"></param>
        /// <param name="userWeight"></param>
        /// <returns></returns>
        private static double IMT(string userHeight, string userWeight)
        {
            return Convert.ToDouble(userWeight) / Math.Pow(Convert.ToDouble(userHeight) / 100, 2);
        }
    }
}
