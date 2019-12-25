using System;

namespace Number1I_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first side of the triangle: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second side of the triangle: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the third side of the triangle: ");     // a и b - боковые стороны, а c - основание.
                double c = Convert.ToDouble(Console.ReadLine());


                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Error.");
                }
                                                                                         
                else
                {
                    if (a + b < c || b + c < a || a + c < b)
                    {
                        Console.WriteLine("There is no triangle with such sides.");      //Треугольника с такими сторонами не существует
                    }
                    else
                    {
                        if (a == b)
                        {
                            Console.WriteLine("True.");
                        }
                        if (a != b)
                        {
                            Console.WriteLine("False.");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            } 
                        
            

            
            
             
        }
    }
}
