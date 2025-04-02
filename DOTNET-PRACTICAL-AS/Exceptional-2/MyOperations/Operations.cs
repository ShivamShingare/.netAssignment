using System;

namespace MyOperations
{
    public class Operations
    {
        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(1001, "Division by zero is not allowed.");
            }
        }

        public static int GetArrayElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(1002, "Index is out of range.");
            }
        }
    }
}
