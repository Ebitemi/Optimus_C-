/// <summary>
/// Program to count how many numbers between 1 and 100 are divisible by 3 with no remainder and dsiplay the count
/// </summary>
namespace AssignmentTwoQTwo
{
    public static class TwoA
    {
        public static void DivisiblebyThree()
        {
            int count = 0;
            for (int i = 3; i <= 100; i += 3)
            {
                if (i % 3 == 0) 
                {
                    count++; 
                }
            }
            Console.WriteLine($"The count of all the numbers divisible by 3 between 1-100 is: {count}");
        }
    }
}
