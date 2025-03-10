/// Program that ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
/// </summary>

namespace AssignmentTwoThree
{
    public static class ThreeFour
    {
        public static void ContinousNumber()
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            string input;

            while (true)
            {
                Console.Write("Enter a number or type 'Quit' to exit: ");
                input = Console.ReadLine().Trim();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    uniqueNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("Unique numbers entered:");
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}


      
