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
                BasicMath.Add();
            } else if (chosenCalc == "Sub")
            {
                BasicMath.Subtract();
            } else if (chosenCalc == "Div")
            {
                Advanced.Divide();
            } else if (chosenCalc == "Mult")
            {
                Advanced.Multiply();
            }
            

        }
    }
}
