using System;

namespace Number2I_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000;i++)
            {
                int a = i / 100;
                int c = i % 10;
                int b = i / 10 % 10;
                if (a == c)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
