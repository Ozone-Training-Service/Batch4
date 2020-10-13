using System;

namespace DAY2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b, ans;

            //Console.WriteLine("\t\t\tCalculator");
            //Console.WriteLine("\t\t\t----------");
            //Console.WriteLine("(1)SUM       (2)Product");
            //Console.WriteLine("(3)Division       (4)Subtraction");

            //Console.WriteLine("Enter your choice?");



            //int c = Convert.ToInt32(Console.ReadLine());
            //if (c == 1)
            //{
            //    Console.WriteLine("Enter your nums");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());

            //    ans = a + b;
            //    Console.WriteLine("Sum=" + ans);
            //}
            //else if (c == 2)
            //{
            //    Console.WriteLine("Enter your nums");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());

            //    ans = a * b;
            //    Console.WriteLine("Product=" + ans);
            //}
            //else if (c == 3)
            //{
            //    Console.WriteLine("Enter your nums");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());

            //    ans = a / b;
            //    Console.WriteLine("Division=" + ans);
            //}
            //else if (c == 4)
            //{
            //    Console.WriteLine("Enter your nums");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());

            //    ans = a - b;
            //    Console.WriteLine("Sub=" + ans);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice");
            //}





            Test obj = new Test();
            obj.DoSmething();
            int no= obj.GetANum();         
            Console.WriteLine(no);

            
            obj.Add(10,5);

            Console.WriteLine("Enter your nums");
            int   a = Convert.ToInt32(Console.ReadLine());
            int   b = Convert.ToInt32(Console.ReadLine());
            
            
            int sub = obj.Sub(a, b);

            Console.WriteLine(sub);
            Console.ReadKey();
        }
    }
}
