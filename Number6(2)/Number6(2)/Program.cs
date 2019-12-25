using System;

namespace Number6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            int a = age % 10;
            

            if (age >= 1 && age <= 100)
            {
                if (age >= 11 && age <= 19)
                {
                    Console.WriteLine(age + " лет");
                }
                else
                {
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine(age + " год");
                            break;
                        case 2:
                           
                        case 3:
                           
                        case 4:
                            Console.WriteLine(age + " года");
                            break;
                        case 5:
                            
                        case 6:
                            
                        case 7:
                           
                        case 8:
                           
                        case 9:
                           
                        case 0:
                            Console.WriteLine(age + " лет");
                            break;

                    }
                }
                 
            }
            else 
            {
                Console.WriteLine("Error!");
            }
                
            

    }
        }
}
