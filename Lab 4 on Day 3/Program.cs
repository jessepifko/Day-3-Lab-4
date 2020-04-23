using System;
using System.ComponentModel.DataAnnotations;

namespace Lab_4_on_Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");

            bool valid = false;
            bool validInput = false;
            int Number; 
            int total;
            string cont = "";
            bool runAgain = true;

            while (runAgain)
            {
               // while (!valid)
               // {
                    Console.WriteLine("Please enter a number above 0: ");
                    total = int.Parse(Console.ReadLine());
                    

                   // if (valid == false)
                   // {
                    //    continue;
                    //}
                    //else 
                   // {
                    //    Console.WriteLine("Not an integer, please try again");
                    //}
                    
                    int i;
                   

                    Console.WriteLine("Number: ");
                for (i = 1; i <= total; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Squared: ");
                for (i = 1; i <= total; i++)
                {
                    Console.WriteLine(i * i);
                }

                Console.WriteLine("Cubed: ");
                for (i = 1; i <= total; i++)
                {
                    Console.WriteLine(i * i * i);
                }

                Console.WriteLine("Would you like to continue? y/n");
                    string runAgainString = Console.ReadLine();
                    if (runAgainString == "y")
                    {
                        runAgain = true;
                    }
                    else
                    {
                        break;
                    }

                }

            }
        }
    }

