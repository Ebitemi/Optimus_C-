/// Program that asks the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name
/// </summary>


namespace AssignmentTwoThree
{
    public static class ThreeTwo
    {
        public static string ReverseName()
        {
            Console.WriteLine("Enter a name");
            string Name = Console.ReadLine();
            char[] nameArray = Name.ToCharArray();
            Array.Reverse(nameArray);

            return new string(nameArray);

        }
    }
}
