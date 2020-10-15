using System;

namespace StudentMangementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Enter 1st student details");

            Console.WriteLine("Enter roll num");
            s1.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name");
            s1.Name = Console.ReadLine();


            Console.WriteLine("Enter Mark");
            s1.M1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n=================================\n");

            Student s2 = new Student();
            Console.WriteLine("Enter 2st student details");

            Console.WriteLine("Enter roll num");
            s2.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name");
            s2.Name = Console.ReadLine();


            Console.WriteLine("Enter Mark");
            s2.M1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("\n\n\t\t\toutput\n\n\n");

            Console.WriteLine("RollNo     Name           mark");
            Console.WriteLine("\n____________________________________\n");

            Console.WriteLine(s1.RollNumber+"  "+s1.Name+"  "+s1.M1);
            Console.WriteLine("\n____________________________________\n");
            Console.WriteLine(s2.RollNumber + "   " + s2.Name + " " + s2.M1);

            Console.ReadKey();



           
        }
    }
}
