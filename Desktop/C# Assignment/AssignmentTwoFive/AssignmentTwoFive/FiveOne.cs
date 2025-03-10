/// Program that eads a text file and displays the number of words.
/// </summary>

namespace AssignmentTwoFive
{
    public static  class FiveOne
    {
        public static void NumberofWords()
        {
            Console.Write("Enter the path of the text file: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file does not exist.");
                 
            }

            try
            {
              
                string fileContent = File.ReadAllText(filePath);

                
                string[] words = fileContent.Split(
                    new[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?' },
                    StringSplitOptions.RemoveEmptyEntries
                );

              
                Console.WriteLine("Number of words: " + words.Length);
            }
            catch (Exception ex)
            {
            
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}