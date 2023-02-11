using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues compare = new CompareValues();

            int maxIntegerValue = compare.MaximumValue<int>(30, 20, 10);
            float maxFloatValue = compare.MaximumValue<float>(30.33f, 20.22f, 10.55f);
            string maxStringValue = compare.MaximumValue<string>("Apple", "Peach", "Banana");
            Console.WriteLine(maxIntegerValue);
            Console.WriteLine(maxFloatValue);
            Console.WriteLine(maxStringValue);
        }
    }
}
