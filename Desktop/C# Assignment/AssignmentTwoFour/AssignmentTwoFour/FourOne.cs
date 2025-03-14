﻿/// Program that asks Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive
/// </summary>
namespace AssignmentTwoFour
{
    public static class FourOne
    {
        public static void Consecutive()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            foreach (string number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            bool isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            string message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
    
    }
}
