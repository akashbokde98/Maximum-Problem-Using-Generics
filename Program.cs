using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            float maxNumber = compare.MaxFloatNumber(10.5f, 5.5f, 2.5f);
            Console.WriteLine(maxNumber);
        }
    }
}
