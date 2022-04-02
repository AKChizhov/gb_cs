using System;

namespace lessonfuck5_1
{
    class Program
    {
        static void MatrixDisplay<T>(T[,] matrix)

        {

            for (int i = 0; i < matrix.GetLength(0); i++)

            {

                for (int j = 0; j < matrix.GetLength(1); j++)

                {

                    Console.Write($"{matrix[i, j]} ");

                }

                Console.WriteLine();

            }

            Console.ReadKey();

        }

        static void MatrixDisplayDiag<T>(T[,] matrix)

        {

            for (int i = 0; i < matrix.GetLength(0); i++)

            {

                for (int j = 0; j < matrix.GetLength(1); j++)

                {

                    if (i == j) Console.Write($"{matrix[i, j]} ");

                    else Console.Write(" ");

                }

                Console.WriteLine();

            }

            Console.ReadKey();

        }

        static void Main(string[] args)

        {

            int[,] matrix = new int[5, 5];

            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)

            {

                for (int j = 0; j < matrix.GetLength(1); j++)

                {

                    matrix[i, j] = rnd.Next(1, 9);

                }

            }

            MatrixDisplay<int>(matrix);

            Console.WriteLine();

            MatrixDisplayDiag<int>(matrix);

            Console.WriteLine();

            string[,] contacts = new string[5, 2]{

{"Иван Петов", "+7 812 337-00-11, ipetrov@mail.ru"},

{"Василий Иванов", "+7 812 337-00-11, vivanov@gmail.ru"},

{"Николай Соколов", "+7 812 337-00-11, niksokol@yandex.ru"},

{"Дмитрий Рыков", "+7 812 337-00-11, dimrykov@rambler.ru"},

{"Дарья Земскова", "+7 812 337-00-11, dzemskova@mail.ru"}

};

            MatrixDisplay<string>(contacts);

            Console.WriteLine();

            while (true)

            {

                Console.Write("Введите любой текст: ");

                string inputLine = Console.ReadLine();

                string outputLine = String.Empty;

                for (int i = inputLine.Length - 1; i >= 0; i--)

                {

                    outputLine += inputLine[i];

                }

                Console.WriteLine($"Ваш текст задом наперед: {outputLine}");

                Console.WriteLine("Для продолжения нажмите любую клавишу");

                Console.WriteLine("Для выхода ESC");

                var keyPressed = Console.ReadKey();

                int keyCode = (int)keyPressed.KeyChar;

                if (keyCode == 27) break;

            }

            Console.WriteLine(" ---Морской бой---");

            Console.ReadKey();

            string[,] battleField = new string[10, 10] {

{"X","0","X","0","X","0","0","0","X","0"},

{"X","0","X","0","X","0","0","0","X","0"},

{"X","0","X","0","X","X","0","0","0","X"},

{"X","0","0","0","0","0","0","0","0","X"},

{"0","0","X","X","X","0","0","0","0","0"},

{"0","0","0","0","0","0","0","0","0","0"},

{"0","0","0","X","X","X","0","0","X","0"},

{"0","0","0","0","0","0","0","0","X","0"},

{"0","0","0","0","X","0","0","0","0","0"},

{"X","X","X","0","X","0","0","X","X","X"}

};

            MatrixDisplay<string>(battleField);

        }
    }
}
