/// Program that ask the user to supply a list of comma separated numbers. If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list
/// </summary>


namespace AssignmentTwoThree
{
    public static class ThreeFive
    {
        public static void CommaSeperated()
        {
            while (true)
            {

                Console.Write("Enter a list of comma-separated numbers:");
                string input = Console.ReadLine();

                string[] inputArray = input.Split(',');

                inputArray = inputArray.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

                if (inputArray.Length < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue;
                }

                int[] numbers = new int[inputArray.Length];
                bool validInput = true;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (!int.TryParse(inputArray[i].Trim(), out numbers[i]))
                    {
                        Console.WriteLine("Invalid List. Please make sure all entries are valid numbers.");
                        validInput = false;
                        break;
                    }
                }

                if (!validInput)
                {
                    continue;
                }

                Array.Sort(numbers);

                Console.WriteLine("The 3 smallest numbers are: ");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

                break;
            }

        }

    }
}
