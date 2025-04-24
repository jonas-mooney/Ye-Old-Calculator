namespace Ye_Old_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // create a loop that only exits under certain conditions
            // condense math functions to be DRY

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

                string input = Console.ReadLine() ?? "Add";
                string chosenCalc = string.IsNullOrWhiteSpace(input) ? "Add" : input;

                Console.WriteLine($"Great, let's {chosenCalc}!");
                if (chosenCalc == "Add")
                {
                    BasicMath.Add();
                }
                else if (chosenCalc == "Sub")
                {
                    BasicMath.Subtract();
                }
                else if (chosenCalc == "Div")
                {
                    Advanced.Divide();
                }
                else if (chosenCalc == "Mult")
                {
                    Advanced.Multiply();
                } else
                {
                    Console.WriteLine("Invalid input, please try again");
                }

            }
            

        }
    }
}
