using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            CompareValues<int> max1 = new CompareValues<int>(intArr);

            float[] floatArr = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
            CompareValues<float> max2 = new CompareValues<float>(floatArr);

            string[] stringArr = { "Apple", "Peach", "Mango", "Banana", "Guava" };
            CompareValues<string> max3 = new CompareValues<string>(stringArr);

            Console.WriteLine(max1.MaximumValue());
            Console.WriteLine(max2.MaximumValue());
            Console.WriteLine(max3.MaximumValue());
        }
    }
}
