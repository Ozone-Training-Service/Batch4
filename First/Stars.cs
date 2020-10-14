using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace First
{
    class Stars
    {
        public void star(int a)
        {
            for(int i=0; i<a; i++)
            {
                for(int j = 0; j <= i;j++)
                    {
                    Console.Write("*");
            }
                Console.WriteLine("");
            }
        }
    }
}
