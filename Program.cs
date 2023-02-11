using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            float maxNumber = compare.MaxFloatNumber(5.5f, 10.5f, 10.5f);
            Console.WriteLine(maxNumber);
        }
    }
}
