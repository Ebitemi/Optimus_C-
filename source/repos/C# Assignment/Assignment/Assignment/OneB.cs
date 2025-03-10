
//Program which takes two numbers from the console and displays the maximum of the two.
namespace Assignment
{
    public static class OneB
    {
        public static void Maximum()
        {
            Console.WriteLine("Enter first number");
            double numOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            double max = Math.Max(numOne, numTwo);
            Console.WriteLine("The maximum number is: " + max);


        }
    }
}