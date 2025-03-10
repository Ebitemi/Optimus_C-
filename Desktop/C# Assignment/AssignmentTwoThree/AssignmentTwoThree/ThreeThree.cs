
using System.Collections.Generic;

/// Program that ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result.
/// </summary>

namespace AssignmentTwoThree
{
    public class Threethree
    {
        public static void SortUniqueNumbers()
        {
            List<int> numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                int userInput;

                bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);

                if (!isValidInput)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                if (numbers.Contains(userInput))
                {
                    Console.WriteLine("Error: You've already entered this number. Please try again.");
                }
                else
                {
                    numbers.Add(userInput);
                }
            }

            numbers.Sort();
            Console.WriteLine("The sorted unique numbers are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
