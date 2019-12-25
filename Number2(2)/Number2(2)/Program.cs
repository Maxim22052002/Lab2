using System;

namespace Number2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double total = 1;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = 1;
            for (int i = 3; i <= a; i += 2)
            {
                if (counter % 2 == 0)
                {
                    total -= b / i;

                }
                else if (counter % 2 == 1)
                {
                    total += b / i;
                }
                counter++;  
            }
            Console.WriteLine(total * 4);
            Console.WriteLine(Math.PI);
        }
    }
}
