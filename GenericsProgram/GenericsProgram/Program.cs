using System;
namespace GenericsProgram
{
    internal class Program
    {
    static void Main(string[] args)
    {
            Console.WriteLine("Welcome to Generics Based Problem");
            Console.WriteLine("Please select given options");
            Console.WriteLine("1.FindIntergerMaximumNumber\n2.Exit\n");
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
                default:
                    Console.Clear();
                    Console.WriteLine("Please select only given options");
                    break;
            }
            
        }

    }
}
