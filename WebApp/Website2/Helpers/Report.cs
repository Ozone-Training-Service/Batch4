using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Website2.Helpers
{
    public class Report
    {

        public void createReport(string name,string address) 
        {

            Random rn = new Random();
            int no = rn.Next(10000,400000);                                                            /// vishnu1223.txt

            string fileName = @"C:\Users\Dell E6520\source\repos\Batch4\WebApp\Website2\Reports\"+name+no+".text";
          
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write("Name:"+name);
                writer.Write("Address:" + address);

                ///



                }
           
            

        }
    }
}
