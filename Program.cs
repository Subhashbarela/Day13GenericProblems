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
            Console.WriteLine("insert the First number :");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert the Second number :");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert the third number :");
            double num3 = Convert.ToDouble(Console.ReadLine());


            double result = Maximum.MaxIntNumber(num1, num2, num3);
            Console.WriteLine("{0} number is gretest of other values :",result);


            Console.ReadLine();
        }
    }
}
