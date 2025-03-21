﻿/// Program that asks the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. The program should still display "NumberOfStudents".
/// </summary>
namespace AssignmentTwoFour
{
    public static class FourFour
    {
        public static void PascalCase()
        {
            Console.Write("Enter a few words: ");
            string input = Console.ReadLine();

            string variableName = "";
            foreach (string word in input.Split(' '))
            {
                string wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }


    }
}

