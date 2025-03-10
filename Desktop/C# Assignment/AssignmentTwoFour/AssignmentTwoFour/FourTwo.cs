/// Program that asks the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
/// </summary>
namespace AssignmentTwoFour
{
    public static class FourTwo
    {
        public static void HyphenDuplicate()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            List<int> numbers = new List<int>();
            foreach (string number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            List<int> uniques = new List<int>();
            bool includesDuplicates = false;
            foreach (int number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }

    }
}
