using System;
using static System.Console;

namespace АСД_Лаба_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(ReadLine());
            int n = Convert.ToInt32(ReadLine());
            int temp;
            int[,] array = new int [m, n];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rnd.Next(0, 10);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Write(array[i, j] + " ");
                }
                WriteLine("");
            }
            WriteLine("\n");

            for (int i = 0; i < n; i++)
            {
                temp = array[0, i];
                array[0, i] = array[m-1, i];
                array[m-1, i] =  temp;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Write(array[i, j] + " ");
                }
                WriteLine();
            }

        }  
    }
}
