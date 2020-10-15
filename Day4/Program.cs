using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Enter name");
            //s1.x = Console.ReadLine();
          
            s1.setName(Console.ReadLine());

            Console.WriteLine("Your Name is");
            
            Console.WriteLine(s1.getName());
           
        }
    }
}
