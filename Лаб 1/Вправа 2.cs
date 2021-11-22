using System;

using static System.Math;

namespace ASD
{
    class Program
    {
        static void Main()
        {
            //отримання даних користувача
            Console.Write("d1:\t");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("d2:\t");
            int d2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("m1:\t");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("m2:\t");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y1:\t");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y2:\t");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int[] Month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (m1 <= Month.Length && m2 <= Month.Length && d1 <= Month[m1] && d2 <= Month[m2])
            {   
                //перевірка на високосність 
                bool leap_year(int a) 
                {

                    if (a % 4 == 0 && a % 100 != 0)
                        return true;
                    

                    else if (a % 400 == 0)
                        return true;

                    else
                        return false;

                }

                int Summ1 = 0, Summ2 = 0;

                //підрахунок кiлькості днiв до нового року

                for (int i = m1 - 1; i < 12; i++)
                {

                    if (leap_year(y1))
                        Month[1] = 29;  //якщо рік є високосний, то другому місяцю присовуємо 29 днів

                    else
                        Month[1] = 28;

                    Summ1 += Month[i]; 

                }

                for (int i = 1; i < m2 - 1; i++)
                {

                    if (leap_year(y2))
                        Month[1] = 29;

                    else
                        Month[1] = 28;

                    Summ2 += Month[i]; 

                }

                int k = 0;

                if (leap_year(y1)) //у високосний рiк виводило на 1 день бiльше

                    if (y1 == y2)
                    {
                        k = 1;
                    }

                int s = Month[m1 - 1] - d1 + d2 + Summ1 + Summ2 - k;

                int j = 0;

                for (int i = y1 + 1; i <= y2 - 1; i++)
                {

                    if (i % 4 == 0 && i % 100 != 0)
                     j++;

                    else if (i % 400 == 0)
                        j++;

                }
                //виведення даних
                int days = s + 366 * j + 365 * (y2 - 1 - y1 - j);
                
                Console.Write("Пройдена кiлькiсть днiв: ");
                Console.WriteLine(days);

                int years = 0;

                if (m2 > m1)
                {
                    years = y2 - y1;
                }

                else
                {
                        years = y2 - y1 - 1;
                }

                Console.WriteLine("Пройшло повних рокiв: " + years);

            }

            else
                Console.WriteLine("Некоректні дані");

        }

    }
}


