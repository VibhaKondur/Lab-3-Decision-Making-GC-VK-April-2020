using System;
using System.ComponentModel.DataAnnotations;

namespace GC_Lab_3_Decision_Making_VK_4_22_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;

            string name = "";
            Console.WriteLine("Hey what's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);

            while (runAgain)
            {
                runAgain = false;

                Console.WriteLine("Please enter an integer between 1 and 100");
                int i = int.Parse(Console.ReadLine());


                if (i < 1 || i > 100)
                {
                    Console.WriteLine("Sorry " + name + ". The value you input is either less than 1 or more than 100, which caused an error. Would you like to try again - yes or no?");
                    string runAgainString = Console.ReadLine();
                    if (runAgainString == "yes")
                    {
                        runAgain = true;
                    }
                }
                else
                {
                    if (i % 2 != 0 && i <= 100)
                    {
                        Console.WriteLine("Thanks " + name + ". This integer is odd");
                    }
                    else if (i % 2 == 0 && i >= 2 && i <= 25)
                    {
                        Console.WriteLine("Thanks " + name + ". This integer is even and less than 25");
                    }
                    else if (i % 2 == 0 && i >= 26 && i <= 60)
                    {
                        Console.WriteLine("Thanks " + name + ". This integer is even");
                    }
                    else if (i % 2 == 0 && i > 60)
                    {
                        Console.WriteLine("Thanks " + name + ". This integer is even");
                    }
                    else if (i % 2 != 0 && i > 60)
                    {
                        Console.WriteLine("Thanks " + name + ". This integer is odd");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Great job " + name + "! Would you like to continue - yes or no?");
                    string runAgainString = Console.ReadLine();
                    if (runAgainString == "yes")
                    {
                        runAgain = true;
                    }
                }
            }
        }
    }

}

     