using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 1;
            string fullName = "Brendan Einhorn";
            var today = DateTime.Now;
            var day = today.Day;
            var month = today.Month;
            var year = today.Year;

            Console.WriteLine($"{fullName} drank {numberOfCupsOfCoffee} cup of coffee on day {day} of month number {month} of the year {year}.");

            Console.Write("What is your name? \n");
            var username = Console.ReadLine();
            if (username == "Alice")
            {
                Console.WriteLine($"We were waiting for you, {username}. \nThank you for visiting us today!\n");
            }
            else
            {
                Console.WriteLine($"Nice to meet you, {username}. \nThank you for visiting us today! \n");
            }
            Console.Write($"{username}, please enter one number as an interger. \n");
            string firstNumberAsString = Console.ReadLine();
            Console.Write($"{username}, please enter a second number as an interger. \n");
            string secondNumberAsString = Console.ReadLine();

            var firstOperand = int.Parse(firstNumberAsString);
            var secondOperand = int.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            Console.WriteLine($"The value of your two numbers added together is {sum}");

            var difference = firstOperand - secondOperand;
            Console.WriteLine($"The value of your two numbers after second number subtracted from your first number is {difference}");

            var product = firstOperand * secondOperand;
            Console.WriteLine($"The value of your two numbers multiplied together is {product}");

            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"The value of your two numbers after the first one is divided by the second one is {quotient}");

            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"When your first number is dividend by your second number, the remainder will be {remainder}");


        }
    }
}