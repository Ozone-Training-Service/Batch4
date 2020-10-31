using Batch4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batch4
{
    public class test
    {

        static void Main(string[] args)
        {
            List<string> city = new List<string>();

            city.Add("Kollam");
            city.Add("TVM");
            city.Add("Ernakulam");

            foreach  (var  item in city)
            {
                Console.WriteLine(item);
            }
            ///////////////////////////////////////


            Student s1 = new Student();
            s1.RollNo = 1;
            s1.Name = "Anil";



            Student s2 = new Student();
            s2.RollNo = 2;
            s2.Name = "Sujith";



            Student s3 = new Student();
            s3.RollNo = 3;
            s3.Name = "Vishnu";


            List<Student> studentList = new List<Student>();
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);



            foreach (var item in studentList)
            {
                Console.WriteLine(item+"  "+item.RollNo+"  "+item.Name);
                
            }


            Console.ReadKey();
        }
    }
}
