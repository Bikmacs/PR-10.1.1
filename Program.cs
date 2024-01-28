using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {

                Random rnd = new Random();
                Console.WriteLine("Введите размер массива");
                int n = int.Parse(Console.ReadLine());

                int[,] aboba = new int[n, n];
                for (int i = 0; i < aboba.GetLength(0); i++)
                {
                    for (int j = 0; j < aboba.GetLength(1); j++)
                    {
                        aboba[i, j] = rnd.Next(0, 100);
                        Console.Write(aboba[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int count = 0;
                Console.WriteLine("введите к");
                int k = int.Parse(Console.ReadLine());

                for (int i = 0; i < aboba.GetLength(0); i++)
                {
                    for (int j = 0; j < aboba.GetLength(1); j++)
                    {
                        if ((aboba[i, j] > 0) && (aboba[i, j] % k == 0))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine();
                }
                Console.Write($"кратных к = {count}");

                int sum = 0;
                for (int i = 0; i < aboba.GetLength(0); i++)
                {
                    for (int j = 0; j < aboba.GetLength(1); j++)
                    {
                        sum += aboba[i, j];
                    }
                    Console.WriteLine();
                }
                Console.Write($"сумма к1 к2 {sum}");

                //19



                Random rnd = new Random();
                Console.WriteLine("Введите размер массива");
                int n = int.Parse(Console.ReadLine());

                int[,] aboba = new int[n, n];
                for (int i = 0; i < aboba.GetLength(0); i++)
                {
                    for (int j = 0; j < aboba.GetLength(1); j++)
                    {
                        aboba[i, j] = rnd.Next(0, 100);
                        Console.Write(aboba[i, j] + " ");
                    }
                    Console.WriteLine();
                    int[,] array = new int[n, n];

                    int a = 2;
                int b = 3;
                int k1 = 0;
                int k2 = 2;

                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                
                int count = 0;
                foreach (int element in array)
                {
                    if (element % a == 0 || element % b == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Количество элементов, кратных a или b: " + count);

     
                for (int col = k1; col <= k2; col++)
                {
                    int product = 1;
                    for (int row = 0; row < rows; row++)
                    {
                        if (array[row, col] < 0)
                        {
                            product *= array[row, col];
                        }
                    }
                    Console.WriteLine("Произведение отрицательных элементов в столбце " + col + ": " + product);
                }




                Console.Read();
            }
            catch
            {
              Console.WriteLine("Ошибка");
            }

        }
    }
}
