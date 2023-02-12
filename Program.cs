using System;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            TestMaximum<int> max1 = new TestMaximum<int>(intArr);

            float[] floatArr = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
            TestMaximum<float> max2 = new TestMaximum<float>(floatArr);

            string[] stringArr = { "Apple", "Peach", "Mango", "Banana", "Guava" };
            TestMaximum<string> max3 = new TestMaximum<string>(stringArr);

            Console.WriteLine(max1.PrintMax());
            Console.WriteLine(max2.PrintMax());
            Console.WriteLine(max3.PrintMax());
        }
    }
}
