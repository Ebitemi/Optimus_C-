//Simple calculator


namespace Assignment
{
    public static class Calculator
    {
        public static void ArithmeticOperations()
        {
            string response;
            do
            {
                int result;
                Console.Write("Enter a number:  ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your desired operation(+,-,*,/): ");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("The sum is: " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("The difference is: " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("The product is: " + result);
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                        }

                        else if (num1 % num2 != 0)
                        {
                            double resultant = (double)(num1) / num2;
                            Console.WriteLine("The quotient is: " + resultant);
                        }

                        else
                        {
                            result = (num1 / num2);
                            Console.WriteLine("The quotient is: " + result);
                        }

                        break;

                    default:
                        Console.WriteLine("Undefined operation");
                        break;
                }
                Console.Write("Do you want to perform another operation ? (y/n):");
                response = Console.ReadLine();
            }
            while (response == "y" || response == "Y");
        }
    }

}
    
 
