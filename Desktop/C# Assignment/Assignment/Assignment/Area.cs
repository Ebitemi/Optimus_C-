//Program to calculate area of a square
namespace AssignmentOne
{
    public class Area
    {
        public static void SquareArea()
        {
            Console.WriteLine("Enter the value for length");
            int length = int.Parse(Console.ReadLine());
            int Area = length * length;
            Console.WriteLine("The area is:" + Area);
        }
    }
}
