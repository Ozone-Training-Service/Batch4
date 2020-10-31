using System;
using System.Collections.Generic;

namespace Batch4
{
    class Program
    {
        static void Main(string[] args)
        {

            Object[] b = new object[20];


            int[] A = new int[10];
           // A[11] = 99;

          
            
            for (int i = 0; i < A.Length; i++)
            {

                A[i] = i * 10;
            }
            Console.WriteLine("output");

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(i);//  o 1 2 3 
                Console.WriteLine(A[i]);// 10 20 
            }

           
          
            foreach (int i in  A)
            {
                Console.WriteLine(i);// 10 ,20 ,30
            }

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }




}
