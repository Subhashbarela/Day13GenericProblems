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
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert the Second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert the third number :");
            int num3 = Convert.ToInt32(Console.ReadLine());


            int result = Maximum.MaxIntNumber(num1, num2, num3);
            Console.WriteLine("{0} number is gretest of other values :",result);


            Console.ReadLine();
        }
    }
}
