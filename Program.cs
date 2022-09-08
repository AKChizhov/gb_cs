using System;

namespace Lesson3

{
    class Program
    {
        /// <summary>
        /// Метод расчета чисел Фибоначчи
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Calc(int n)
        {
            if (n == 1 || n == 2)
            {
                return n - 1;
            }
            return Calc(n - 1) + Calc(n - 2);
        }
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("        Вычисление значений чисел ряда Фибоначчи.");
            Console.Write("           Введите номер числа ряда (n больше 0): ");
            string inputN = Console.ReadLine();
            try

            {
                int n = Convert.ToInt32(inputN);

                if (n < 1)
                {
                    Console.WriteLine("Номер должен быть > 0");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("       Ряд Фибоначчи для п =" + (n) + ": ");
                for (int i = 1; i <= n; i++)

                {
                    Console.WriteLine("      -Число Фибоначчи для n=" + (i) + "  " + Calc(i));
                }
                Console.WriteLine("      Значение Фибоначчи (для n=" + (n) + ")  " + Calc(n));

            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод.");
            }
            Console.WriteLine("====================================================");
            Console.ReadKey();

        }
    }
}



