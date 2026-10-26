using Tyuiu.KhomutovaLE.Sprint4.Task3.V11.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KhomutovaLE.Sprint4.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Хомутова Л. Е. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Хомутова Лидия Евгеньевна | РППб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Подсчитайте              *");
            Console.WriteLine("* количество нечетных элементов во всем массиве.                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Матрица:");
            int[,] array = { {8, 6, 9, 4, 5 },
                            {9, 4, 8, 5, 6 },
                            {9, 7, 9, 8, 4 },
                            {4, 6, 5, 7, 8 },
                            {6, 6, 7, 6, 4 }, };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(array));

            Console.ReadLine();
        }
    }
}
