
using System.Collections.Generic;

/// Program that ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result.
/// </summary>

namespace AssignmentTwoThree
{
    public class Threethree
    {
        public static void SortUniqueNumbers()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Type 5 unique numbers:");
                var input = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(input))
                {
                    Console.WriteLine("Error! Number already in list!");
                }

                else
                {
                    numbers.Add(input);
                }

            }

            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.Write("The unique numbers are:{0} ", number);
            }
        }
    }
}
