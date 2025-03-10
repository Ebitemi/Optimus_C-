/// Program that picks a random number between 1 and 10, gives the user 4 chances to guess the number.and retuns a string if correct or incorrect
/// </summary>
namespace AssignmentTwoQTwo
{
    public static class TwoD
    {
        public static string Guess()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11);
            int attempt = 0;
            Console.WriteLine(secretNumber);
            Console.WriteLine("You have 4 attempts to guess my secret number which is between 1-10.\nIf your guess is correct, you win!");

            while (attempt < 4)
            {
                Console.WriteLine("Enter the number you guess");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    return "You won!";
                }
                attempt++;
            }

            return "You lost";

        }
    }
}