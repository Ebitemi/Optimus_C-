/// Program that continuously asks the user to enter a number or "ok" to exit and returns the sum of all the previously entered numbers
/// </summary>
namespace AssignmentTwoQTwo
{
    public static class TwoB
    {
        public static void ContinuousNumbers()
        {
            double sum = 0;

            while (true)
            {
                Console.Write("Enter a number (or type 'ok' to exit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }

                if (double.TryParse(input, out double number))
                {
                    sum += number;
                }
              
            }

            Console.WriteLine($"The sum of all entered numbers is: {sum}");




        }
    }
}
