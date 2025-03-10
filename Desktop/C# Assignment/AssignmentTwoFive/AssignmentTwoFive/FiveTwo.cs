///// Program that reads a text file and displays the longest word in the text

namespace AssignmentTwoFive
{
    public static class FiveTwo
    {
        public static void LongestWord()
        {
            Console.Write("Enter the path of the text file: ");
            string filePath = Console.ReadLine();

            // Check if the file exists
            //if (!File.Exists(filePath))
            //{
            //    Console.WriteLine("The file does not exist.");
            //    return;
            //}

            try
            {
                // Read the content of the file
                string fileContent = File.ReadAllText(filePath);

                // Split the content into words based on spaces and punctuation
                string[] words = fileContent.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?', '-', '_', '(', ')', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                // Initialize a variable to track the longest word
                string longestWord = string.Empty;

                // Iterate over each word
                foreach (string word in words)
                {
                    // Check if the current word is longer than the longest word found so far
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                // Display the longest word found
                if (string.IsNullOrEmpty(longestWord))
                {
                    Console.WriteLine("No words found in the file.");
                }
                else
                {
                    Console.WriteLine("The longest word is: " + longestWord);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur during file reading
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }


}
