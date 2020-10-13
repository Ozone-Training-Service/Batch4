using System;

namespace DAY2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, ans;

            Console.WriteLine("\t\t\tCalculator");
            Console.WriteLine("\t\t\t----------");
            Console.WriteLine("(1)SUM       (2)Product");
            Console.WriteLine("(3)Division       (4)Subtraction");

            Console.WriteLine("Enter your choice?");



            int c = Convert.ToInt32(Console.ReadLine());
            if (c==1)
            {
                Console.WriteLine("Enter your nums");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                ans = a + b;
                Console.WriteLine("Sum=" +ans);
            }
            else if (c == 2)
            {
                Console.WriteLine("Enter your nums");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                ans = a * b;
                Console.WriteLine("Product=" + ans);
            }
            else if (c == 3)
            {
                Console.WriteLine("Enter your nums");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                ans = a/ b;
                Console.WriteLine("Division=" + ans);
            }
            else if (c == 4)
            {
                Console.WriteLine("Enter your nums");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                ans = a - b;
                Console.WriteLine("Sub=" + ans);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }






          

            Console.ReadLine();
        }
    }
}
