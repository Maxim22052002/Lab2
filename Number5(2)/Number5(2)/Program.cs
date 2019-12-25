using System;

namespace Number5_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            bool a = false;
            for (uint x = 1; x < N; x++)
            {
                for (uint y = 1; y < N; y++)
                {
                    for (uint z = 1; z < N; z++)
                    {
                        if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N)
                        {
                            Console.WriteLine(x +" , "+ y + " , "+z);
                            a = true;
                        }

                    }
                }
            }
            if (a == false)
            {
                Console.WriteLine("No such combinations!");
            }
            
        }
    }
}
