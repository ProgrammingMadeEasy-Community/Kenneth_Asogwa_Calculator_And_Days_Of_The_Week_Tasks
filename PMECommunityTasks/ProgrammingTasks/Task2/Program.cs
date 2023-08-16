using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {   
       static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7) or a multi-digit number to determine which method to call: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 1 && userInput <= 7)
            {
                ClassOne.DaysOfTheWeek(userInput);
            }
            else if(userInput >= 1 && userInput <= 777)
            {
                    int number1 = userInput / 100;
                    int number2 = (userInput / 10) % 10;
                    int number3 = userInput % 10;
                    ClassTwo.DaysOfTheWeek(number1, number2, number3);            
            }
            else
            {
               Console.WriteLine("Invalid input. Please enter a number between 1 and 7");
            }

            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();      

            
        }

    }
}
