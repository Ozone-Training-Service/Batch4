using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class odd
    {
        public void oddOreven()
        {
            int a;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The number is even");

            }
            else
            {
                Console.WriteLine("The number is odd");
            } }

    }
}
