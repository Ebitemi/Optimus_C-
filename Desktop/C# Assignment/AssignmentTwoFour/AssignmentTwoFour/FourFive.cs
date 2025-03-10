/// Program that asks the user to enter an English word. Count the number of vowels in the word. 
/// </summary>

namespace AssignmentTwoFour
{
    public static class FourFive
    {
        public static void Vowels()
        {
            Console.Write("Enter a word: ");

            string input = Console.ReadLine().ToLower();

            List<char> vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            int vowelsCount = 0;
            foreach (char character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
    
}
