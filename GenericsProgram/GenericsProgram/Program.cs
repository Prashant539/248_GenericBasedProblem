using System;
namespace GenericsProgram
{
    internal class Program
    {
    static void Main(string[] args)
    {
            Console.WriteLine("Welcome to Generics Based Problem");
            Console.WriteLine("Please select given options");
            Console.WriteLine("1.FindIntergerMaximumNumber\n2.FindMaxFloatNumber\n3.FindMaxString\n10:Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter three values to find maximum number:");
                    int firstValue = Convert.ToInt32(Console.ReadLine());
                    int secondValue = Convert.ToInt32(Console.ReadLine());
                    int thirdValue = Convert.ToInt32(Console.ReadLine());
                    int output = FindMaxiumNumber.MaximumIntergerNumber(firstValue, secondValue, thirdValue);
                    Console.WriteLine("{0} is the maximum number", output);
                    break;
                case 2:
                    Console.WriteLine("The Greatest Value is {0}", MaxFloat.MaximumFloatNumber(21.5f, 14.9f, 15));
                    Console.WriteLine("The Greatest Value is {0}", MaxFloat.MaximumFloatNumber(12, 90, 15.3f));
                    Console.WriteLine("The Greatest Value is {0}", MaxFloat.MaximumFloatNumber(12, 14, 25.1f));
                    break;
                case 3:
                    Console.WriteLine("The Greatest Value is {0}", MaxString.MaximumString("Apple", "Peach", "Banana"));
                    Console.WriteLine("The Greatest Value is {0}", MaxString.MaximumString("Apple", "Banana", "WaterMelon"));
                    Console.WriteLine("The Greatest Value is {0}", MaxString.MaximumString("Xray", "Banana", "Peach"));
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select only given options");
                    break;
            }
            
        }

    }
}
