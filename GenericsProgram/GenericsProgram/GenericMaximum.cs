using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class GenericMaximum<T> where T : IComparable
    {
        public static T MaxValueCheck(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue ,SecondValue and thirdValue are same");
        }
    }
}
