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
            /*value.firstValue = 1;
            value.secondValue = 2;
            value.thirdValue = 3;  */
            //CompareValues compare = new CompareValues();

            /*int maxIntegerValue = value.MaximumValue<int>(30, 20, 10);
            float maxFloatValue = value.MaximumValue<float>(30.33f, 20.22f, 10.55f);
            string maxStringValue = value.MaximumValue<string>("Apple", "Peach", "Banana");
            Console.WriteLine(maxIntegerValue);
            Console.WriteLine(maxFloatValue);
            Console.WriteLine(maxStringValue);*/
        }
    }
}
