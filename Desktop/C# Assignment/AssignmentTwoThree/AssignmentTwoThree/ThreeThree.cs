
using System.Collections.Generic;

/// Program that ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result.
/// </summary>

namespace AssignmentTwoThree
{
    public class Threethree
    {
        public static void SortUniqueNumbers()
        {
            List<int> list = new List<int>();

            while (list.Count < 5)
            {
                Console.WriteLine("Type 5 unique numbers:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (list.Contains(input))
                    Console.WriteLine("Error! Number already in list!");
                else
                    list.Add(input);
            }

            list.Sort();
            foreach (int number in list)
            {
                Console.Write("{0} ", number);
            }


        }
    }
    
}
