/// Program that ask the user to enter a series of numbers separated by comma, find the maximum of the numbers and display it
/// </summary>
namespace AssignmentTwoQTwo
{
    public static class TwoE
    {
        public static void Maximum()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma");
            string[] inputArray = Console.ReadLine().Split(",");
            int[] convertedArray = Array.ConvertAll(inputArray, s => int.Parse(s.Trim()));
            int maxNumber = convertedArray.Max();
            Console.WriteLine($"The maximum number is: {maxNumber}");
        }
    }
}
