using System;
using MyOperations;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter two numbers for division:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = Operations.Divide(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Error Code: {ex.ErrorCode}, Description: {ex.Message}");
        }

        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Enter index to fetch an element:");
            int index = Convert.ToInt32(Console.ReadLine());

            int value = Operations.GetArrayElement(numbers, index);
            Console.WriteLine("Value: " + value);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Error Code: {ex.ErrorCode}, Description: {ex.Message}");
        }
    }
}
