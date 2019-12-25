using System;

namespace Number3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 1;
            int f2 = 2;
            int f0 = 1;
            int counter = 0;
            while (true)
            {


                f0 = f1;
                f1 = f2;
                f2 = f1 + f0;

                if ((f1 + f2) >= 1000 && (f1 + f2) <= 9999)
                {
                    counter++;
                }
                else if (f1 + f2 > 9999)
                {
                    break;
                }


            }
            Console.WriteLine(counter);
        }
    }
}
