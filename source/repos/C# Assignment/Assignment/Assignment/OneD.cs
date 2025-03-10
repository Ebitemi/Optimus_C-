
//Program that asks for the speed of a car. If the user enters a value less than the speed limit, program displays Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points.
namespace Assignment
{
    public static class OneD
    {
        public static void Speed()
        {
            Console.WriteLine("Enter the speed limit in km/h");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter car speed in km/h");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            int demeritPoint = (carSpeed - speedLimit) / 5;
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK!");
            }
            
            if (demeritPoint > 12)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                Console.WriteLine("Demerit points is " + demeritPoint);
            }
        }
    }
}
