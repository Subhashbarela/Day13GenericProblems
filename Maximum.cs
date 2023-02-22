using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethode
{
    public class Maximum<T> where T : IComparable
    { 

        public T firstValue, secondValue, thirdValue;
    
        public Maximum(T firstValue, T secondValue, T thirdValue) {
        this.firstValue = firstValue;
        this.secondValue = secondValue;
       this.thirdValue = thirdValue;
    }
        
        public   T MaxOfThree()
        {
           
            if(firstValue.CompareTo(secondValue) >0 && firstValue.CompareTo(thirdValue) >0)
               
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 )
               
            {
             return secondValue;
        }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 )
               
            {
            return thirdValue;
        }
            return default;

          
        }
       

//********************************************************************************************************
      /*  public static double MaxOfThree(double firstValue, double secondValue, double thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)

            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)

            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)

            {
                return thirdValue;
            }
            return 0;


        }
        //**************************************************************************************************************

        public static String MaxOfThree(String firstValue, String secondValue, String thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)

            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)

            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)

            {
                return thirdValue;
            }
            return null;


        }*/
    }
}
