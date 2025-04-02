using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_C__1.Programs
{
    class SumOfDigits
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of digits: " + CalculateSum(number));
        }

        static int CalculateSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
