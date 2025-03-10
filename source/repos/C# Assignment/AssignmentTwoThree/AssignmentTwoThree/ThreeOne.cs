/// Program that continuously asks the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message.
/// </summary>


namespace AssignmentTwoThree
{
    public static class ThreeOne
    {
        public static List<string> Names = new List<string>();

        public static string CountLikes()
        {
            Console.WriteLine("Enter a unique name (or press Enter to stop):");
            string uniqueName = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(uniqueName))
            {
                if (Names.Count == 0)
                {
                    return "No one liked your post.";
                }
                if (Names.Count == 1)
                {
                    return $"{Names[0]} liked your post.";
                }
                if (Names.Count == 2)
                {
                    return $"{Names[0]} and {Names[1]} liked your post.";
                }
                if (Names.Count >= 3)
                {
                    return $"{Names[0]}, {Names[1]} and {Names.Count - 2} others liked your post.";
                }
            }

            if (!Names.Contains(uniqueName))
            {
                Names.Add(uniqueName);
            }
            else
            {
                Console.WriteLine("This name has already liked the post. Enter a different name.");
            }

            return CountLikes();
        }
    }
}
