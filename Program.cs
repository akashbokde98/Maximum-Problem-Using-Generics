using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            string maxValue = compare.MaxStringValue("Peach", "Apple", "Banana");
            Console.WriteLine(maxValue);
        }
    }
}
