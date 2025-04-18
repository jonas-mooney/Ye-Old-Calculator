namespace Ye_Old_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This is another boring ol calculator.\n" +
                "Enter one of the following commands to make a calculation: \n" +
                "Add, Sub, Div, Mult");
            string chosenCalc = Console.ReadLine() ?? "Add";

            Console.WriteLine($"Great, let's {chosenCalc}!");
            if (chosenCalc == "Add")
            {
                Console.WriteLine("Enter two numbers separated by a space: \n");
                string numbers = Console.ReadLine();
                string[] numbersCleaned = numbers.Split(" ");
                int num1 = int.Parse(numbersCleaned[0]);
                int num2 = int.Parse(numbersCleaned[1]);
                Console.WriteLine($"The result is {num1 + num2}");
            }
        }
    }
}
