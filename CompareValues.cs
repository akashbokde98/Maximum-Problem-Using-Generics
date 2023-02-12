using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    internal class CompareValues<T> where T : IComparable
    {
        public T[] intArray;
        public CompareValues(T[] arr)
        {
            intArray = arr;
        }

        public T MaximumValue()
        {
            if (intArray[0].CompareTo(intArray[1]) > 0 && intArray[0].CompareTo(intArray[2]) > 0 && intArray[0].CompareTo(intArray[3]) > 0 && intArray[0].CompareTo(intArray[4]) > 0)
            {
                return intArray[0];
            }
            if (intArray[1].CompareTo(intArray[0]) > 0 && intArray[1].CompareTo(intArray[2]) > 0 && intArray[1].CompareTo(intArray[3]) > 0 && intArray[1].CompareTo(intArray[4]) > 0)
            {
                return intArray[1];
            }
            if (intArray[2].CompareTo(intArray[0]) > 0 && intArray[2].CompareTo(intArray[1]) > 0 && intArray[2].CompareTo(intArray[3]) > 0 && intArray[2].CompareTo(intArray[4]) > 0)
            {
                return intArray[2];
            }
            if (intArray[3].CompareTo(intArray[0]) > 0 && intArray[3].CompareTo(intArray[1]) > 0 && intArray[3].CompareTo(intArray[2]) > 0 && intArray[3].CompareTo(intArray[4]) > 0)
            {
                return intArray[3];
            }
            if (intArray[4].CompareTo(intArray[0]) > 0 && intArray[4].CompareTo(intArray[1]) > 0 && intArray[4].CompareTo(intArray[2]) > 0 && intArray[4].CompareTo(intArray[3]) > 0)
            {
                return intArray[4];
            }
            return intArray[0];
        }
    }
}
