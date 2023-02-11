using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            int maxNumber = compare.MaxIntegerNumber(10, 20, 50);
            Console.WriteLine(maxNumber);
        }
    }
}
