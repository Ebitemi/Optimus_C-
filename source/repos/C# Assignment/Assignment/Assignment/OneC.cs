//Program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

namespace Assignment
{
    public static class OneC
    {
        public static void Dimensions() {
            Console.Write("Enter the width of the image: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the image: ");
            double height = Convert.ToDouble(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is in Landscape mode.");
            }
            else
            {
                Console.WriteLine("The image is in Portrait mode.");
            }
            

        }
    }
}
