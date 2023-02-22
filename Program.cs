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
            Maximum<int> Obj1 = new Maximum<int>(3, 5, 6);
            int max1 = Obj1.MaxOfThree();
            Console.WriteLine("{0} String is gretest of other String :", max1);
            Console.WriteLine("\n**********************************\n");

           
            
            Maximum<double> DoubleValue = new Maximum<double>(3.4, 5.5, 6.78);
            double max2 = DoubleValue.MaxOfThree();
            Console.WriteLine("{0} String is gretest of other String :", max2);
            Console.WriteLine("\n**********************************\n");

            
            
            Maximum<String> StringValue = new Maximum<String>("234", "543", "654");
            String max3= StringValue.MaxOfThree();
            Console.WriteLine("{0} String is gretest of other String :",max3);
           



            Console.ReadLine();
          
        }
    }
}
