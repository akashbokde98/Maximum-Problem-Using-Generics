using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            int maxNumber = compare.MaxIntegerNumber(30, 20, 10);
            Console.WriteLine(maxNumber);
        }
    }
}
