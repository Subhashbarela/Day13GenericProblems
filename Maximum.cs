using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethode
{
    internal class Maximum
    {
        
        public static double MaxIntNumber(double firstValue, double seconValue, double thirdValue)
        {
           
            if(firstValue.CompareTo(seconValue)>0 && firstValue.CompareTo(thirdValue) >0 ||
                firstValue.CompareTo(seconValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(seconValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (seconValue.CompareTo(firstValue) > 0 && seconValue.CompareTo(thirdValue) > 0 ||
                seconValue.CompareTo(firstValue) >= 0 && seconValue.CompareTo(thirdValue) > 0 ||
                seconValue.CompareTo(firstValue) > 0 && seconValue.CompareTo(thirdValue) >= 0)
            {
                return seconValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(seconValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(seconValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(seconValue) >= 0)
            {
                return thirdValue;
            }

            return 0;
        }
    }
}
