using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            string name="1";
            //Console.WriteLine("Enter  your name");
            // name = Console.ReadLine();
            // Console.WriteLine(name);

            Console.WriteLine("Enter your nums");

            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Sum="+c);





            Console.ReadLine();


        }
    }
}
