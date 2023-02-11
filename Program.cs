using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            int maxNumber = compare.MaxIntegerNumber(10, 50, 30);
            Console.WriteLine(maxNumber);
        }
    }
}
