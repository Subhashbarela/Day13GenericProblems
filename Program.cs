using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethode
{
   
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("insert the First String :");
           String value1=(Console.ReadLine());
            Console.WriteLine("insert the Second String :");
            String value2 = (Console.ReadLine());
            Console.WriteLine("insert the third String :");
            String value3 = (Console.ReadLine());


            String result = Maximum.MaxIntNumber(value1, value2, value3);
            Console.WriteLine("{0} String is gretest of other String :",result);


            Console.ReadLine();
        }
    }
}
