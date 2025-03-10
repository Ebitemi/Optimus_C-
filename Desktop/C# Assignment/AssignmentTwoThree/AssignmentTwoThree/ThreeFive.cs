/// Program that ask the user to supply a list of comma separated numbers. If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list
/// </summary>


namespace AssignmentTwoThree
{
   public static class ThreeFive
    {
        public static void CommaSeperated()
        {
            var list = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a list of numbers");
                var input = Console.ReadLine();

                var array = input.Split(',');

                if ((array.Length == 0) || (array.Length < 5))
                {
                    Console.WriteLine("Invalid list! Try again.");
                }
                else
                {
                    foreach (var number in array)
                        list.Add(Convert.ToInt32(number));
                    break;
                }
            }
            list.Sort();

            for (int i = 0; i < 3; i++)
                Console.Write("The three smallest numbers are: {0} ", list[i]);
        }
    }

}
