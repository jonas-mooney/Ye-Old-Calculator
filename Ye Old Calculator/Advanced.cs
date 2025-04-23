using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ye_Old_Calculator
{
    internal class Advanced
    {
        public static int Divide()
        {
            Console.WriteLine("Enter two numbers separated by a space: \n");
            string numbers = Console.ReadLine();
            string[] numbersCleaned = numbers.Split(" ");
            int num1 = int.Parse(numbersCleaned[0]);
            int num2 = int.Parse(numbersCleaned[1]);
            Console.WriteLine($"The result is {num1 / num2}");
            return 0;
        }
        public static int Multiply()
        {
            Console.WriteLine("Enter two numbers separated by a space: \n");
            string numbers = Console.ReadLine();
            string[] numbersCleaned = numbers.Split(" ");
            int num1 = int.Parse(numbersCleaned[0]);
            int num2 = int.Parse(numbersCleaned[1]);
            Console.WriteLine($"The result is {num1 * num2}");
            return 0;
        }
    }
}
