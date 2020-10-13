using System;
using System.Collections.Generic;
using System.Text;

namespace DAY2
{
    public class Test
    {
        

        public void DoSmething()
        {   

            int x = 10;
            Console.WriteLine("Num="+x);
            Console.WriteLine("Hello From Test class ");
        }

        public int GetANum()
        {
            Random rn = new Random();
            int no = rn.Next(1000, 2000);

            return no;


           // return 10;
        }


        public void Add(int x,int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum="+sum);
        }


        public int Sub(int x, int y)
        {
            int sub = x - y;

            return sub;
        }
    }
}
