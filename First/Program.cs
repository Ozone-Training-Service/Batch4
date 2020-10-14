using System;
using System.Threading;

namespace First
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //odd obj = new odd();
            //obj.oddOreven();
            // Large obj2 = new Large();
            //int f = obj2.Larger();
            // Console.WriteLine(f+"is the largest number");

            // Console.ReadLine();
            Stars obj3 = new Stars();
            int p;
            Console.WriteLine("enter a number");
            p = Convert.ToInt32(Console.ReadLine());
            obj3.star(p);
        }
    }
}
