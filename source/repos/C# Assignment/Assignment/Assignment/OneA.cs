//Program that displays valid when a number between 1-10
namespace Assignment
{
     public static class One
    {
        public static void ValidNumber() 
        {
            Console.WriteLine("Enter a value between 1 - 10");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine();
        }
       
    }
}
