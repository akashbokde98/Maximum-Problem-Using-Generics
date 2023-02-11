using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareValues<int> max1 = new CompareValues<int>(1,2,3);
            CompareValues<float> max2 = new CompareValues<float>(1.1f, 2.2f, 3.3f);
            CompareValues<string> max3 = new CompareValues<string>("Apple", "Mango", "Banan");
            Console.WriteLine(max1.MaximumValue());
            Console.WriteLine(max2.MaximumValue());
            Console.WriteLine(max3.MaximumValue());
        }
    }
}
