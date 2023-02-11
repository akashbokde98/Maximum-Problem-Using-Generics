using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    internal class CompareValues<T> where T : IComparable
    {
        public T firstValue;
        public T secondValue;
        public T thirdValue;
        public CompareValues(T value1, T value2, T value3)
        {
            firstValue = value1;
            secondValue = value2;
            thirdValue = value3;
        }

        public T MaximumValue()
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
            return firstValue;
        }
    }
}
