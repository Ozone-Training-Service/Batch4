using System;

namespace DAY2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, product;
            
           

            Console.WriteLine("Enter your nums");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            product = a * b;

            Console.WriteLine("Sum=" + sum);
            Console.WriteLine("Product="+product);

            Console.ReadLine();
        }
    }
}
