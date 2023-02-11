using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            string maxValue = compare.MaxStringValue("Apple", "Banana", "Peach");
            Console.WriteLine(maxValue);
        }
    }
}
