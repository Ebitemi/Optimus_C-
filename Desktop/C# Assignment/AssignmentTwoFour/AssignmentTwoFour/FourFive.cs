/// Program that asks the user to enter an English word. Count the number of vowels in the word. 
/// </summary>

namespace AssignmentTwoFour
{
    public static class FourFive
    {
        public static void Vowels()
        {
            Console.Write("Enter a word: ");
       
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
    
}
