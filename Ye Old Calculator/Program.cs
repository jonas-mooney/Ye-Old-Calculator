namespace Ye_Old_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isRunning = true;
            bool hasStartupMessageDisplayed = false;

            while (isRunning == true)
            {
                if (hasStartupMessageDisplayed == false)
                {
                    Console.WriteLine("Welcome! This is another boring ol calculator.\n" +
                    "Enter one of the following commands to make a calculation: \n" +
                    "Add, Sub, Div, Mult");
                    hasStartupMessageDisplayed = true;
                }

                string input = Console.ReadLine();
                string chosenCalc = string.IsNullOrWhiteSpace(input) ? "Add" : input;
                int result = 0;

                Console.WriteLine($"Great, let's {chosenCalc}!\n Please enter two numbers separated by a space.");

                string numbers = Console.ReadLine();
                string[] numbersCleaned = numbers.Split(" ");
                int num1 = int.Parse(numbersCleaned[0]);
                int num2 = int.Parse(numbersCleaned[1]);

                if (chosenCalc == "Add")
                {
                    result = BasicMath.Add(num1, num2);
                }
                else if (chosenCalc == "Sub")
                {
                    result = BasicMath.Subtract(num1, num2);
                }
                else if (chosenCalc == "Div")
                {
                    result = Advanced.Divide(num1, num2);
                }
                else if (chosenCalc == "Mult")
                {
                    result = Advanced.Multiply(num1, num2);
                } else
                {
                    Console.WriteLine("Invalid input, please try again");
                }

                Console.WriteLine($"The result is: {result}");

            }
            

        }
    }
}
