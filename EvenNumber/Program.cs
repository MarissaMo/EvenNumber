using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int method;
            int number;
            string text;
            Console.WriteLine("Hello!");
            while (true)
            {
                Console.WriteLine("Please enter the number you want to check for parity:");
                while (true)
                {
                    string text_number = Console.ReadLine();
                    if (int.TryParse(text_number, out number))
                    {
                        Console.WriteLine("-------------");
                        Console.WriteLine("You entered the number {0}", number);
                        Console.WriteLine("-------------");
                        Console.WriteLine("\n");
                        break;
                    }
                    Console.WriteLine("Failed to recognize the number. Please try again, enter an integer number");
                }

                Console.WriteLine("Please choose a method for determining the parity of a number:");
                Console.WriteLine("1. Checking the division of a number by two without remainder");
                Console.WriteLine("2. Comparing the last digit of a number with 0, 2, 4, 6, 8");
                Console.WriteLine("3. Checking division by 2 only for the last digit of the number");
                Console.WriteLine("Please enter a number from 1 to 3");

                while (true)
                {
                    string text_method = Console.ReadLine();
                    if (int.TryParse(text_method, out method))
                    {
                        //method = Convert.ToInt32(text_number);
                        if (method >= 1 && method <= 3)
                        {
                            Console.WriteLine("-------------");
                            Console.WriteLine("You have chosen method {0}", method);
                            Console.WriteLine("-------------");
                            Console.WriteLine("\n");
                            break;
                        }
                    }
                    Console.WriteLine("Failed to recognize a number from 1 to 3. Please try again, enter a number from 1 to 3");
                }


                if (method == 1)
                {
                    Console.WriteLine("---------------------------");
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("The number {0} is even", number);
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is odd", number);
                    }
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("\n");
                }
                else if (method == 2)
                {
                    Console.WriteLine("---------------------------");
                    if (number % 10 == 0 || number % 10 == 2 || number % 10 == 4 || number % 10 == 6 || number % 10 == 8)
                    {
                        Console.WriteLine("The number {0} is even", number);
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is odd", number);
                    }
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("---------------------------");
                    if ((number % 10) % 2 == 0)
                    {
                        Console.WriteLine("The number {0} is even", number);
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is odd", number);
                    }
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("\n");
                }


                while (true)
                {
                    Console.WriteLine("If you want to check another number please enter 'yes', else enter 'no'");
                    text = Console.ReadLine();
                    if (text == "yes" || text == "no")
                    {
                        break;
                    }
                    Console.WriteLine("Failed to recognize 'yes' or 'no'");
                }

                Console.WriteLine("-------------");
                if (text == "no")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

            }

        }
    }
}