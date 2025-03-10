/// Program that ask the user to enter a number. Compute the factorial of the number and prints it
/// </summary>
namespace AssignmentTwoQTwo
{
    public static class TwoC
    {
        public static void Factorial()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{num}! is { factorial}");
        }
    }
}
