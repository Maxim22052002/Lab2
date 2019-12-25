using System;

namespace Number1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the value a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double discriminant = Math.Pow(b, 2) - 4 * a * c;
                double x1, x2;
                if (a == 0)
                {
                    double x = -(c / b);
                    Console.WriteLine("X= " + x);
                }
                else if (b == 0)
                {
                    x1 = Math.Sqrt(-c / a);
                    x2 = -Math.Sqrt(-c / a);
                    Console.WriteLine("x1= " + x1);
                    Console.WriteLine("x2= " + x2);

                }
                else if (c == 0)
                {
                    Console.WriteLine("x1=0 ");
                    x2 = -(b / a);
                    Console.WriteLine("x2=" + x2);
                }
                else if (discriminant > 0)
                {
                    x1 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                    x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    Console.WriteLine("x1= " + x1);
                    Console.WriteLine("x2= " + x2);
                }

                else if (discriminant == 0)
                {
                    x1 = (-b - Math.Sqrt(discriminant)) / 2 * a; // + or -
                    Console.WriteLine("x1= " + x1);
                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("Discriminant cannot be less than zero! We write in the form of a complex number: ");
                    double x = -b / 2*a;    
                    double y = Math.Sqrt(-discriminant) /( 2*a);
                    Console.WriteLine(x + " + " + y + "i");
                    Console.WriteLine(x + " - " + y + "i");

                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            
            
        }
    }
}
