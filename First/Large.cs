using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class Large
    {
        int a, b, c,d;
        public int Larger()
        {
            Console.WriteLine("Enter 3 number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                if (a > c)
                {
                    d = a;
                   
                }
                else
                {
                    d = c;
                }
            }
            else if(b>c)
            {
                d = b;
            }
            
            return d;
        }


            
    }
}
