using System;

namespace Number4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the х");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the q");
            double q = Convert.ToDouble(Console.ReadLine());
            int N = 2;
            double fact1;
            double counter = 0;
            double step = 1;
            double cos_of_x = 1;
            int counter2 = 0;
            fact1 = factorial_WhileLoop(N);
            while (q <= step)
            {
                if (counter % 2 == 0)
                {
                    
                    step = Math.Pow(x, N) / fact1;
                    cos_of_x -= step;
                    
                }
                else
                {
                    
                    step = Math.Pow(x, N) / fact1;
                    cos_of_x += step;
                    
                }
                counter++;
                N += 2;
                counter2++;

            }
            Console.WriteLine(cos_of_x);
            Console.WriteLine(Math.Cos(x));
            Console.WriteLine(counter2);
        }
        public static double factorial_WhileLoop(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
