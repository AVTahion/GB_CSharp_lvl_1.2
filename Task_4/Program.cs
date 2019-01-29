using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  4) Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина,
       если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки
       логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
       С помощью цикла do while ограничить ввод пароля тремя попытками.
    
    Кушмилов Александр.
*/

namespace Task_4
{
    class Program
    {
        /// <summary>
        /// Метод проверяет входящие логин и пароль на соответствие заданным в методе логину и паролю.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static bool LoginPassCheck(string login, string password)
        {
            string refLogin = "root";
            string refPass = "GeekBrains";
            return (login == refLogin && password == refPass) ? true : false;
        }

        static void Main(string[] args)
        {
            bool passed = false;
            byte i = 0;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();
                passed = LoginPassCheck(login, password);
                Console.WriteLine(passed);
                i++;
            }
            while (i < 3 && !passed);
            if (!passed)
            {
                Console.WriteLine("Аутентификация не пройдена!");
            }
            else
            {
                Console.WriteLine("Аутентификация пройдена.");
            }
            Console.ReadLine();
        }
    }
}
