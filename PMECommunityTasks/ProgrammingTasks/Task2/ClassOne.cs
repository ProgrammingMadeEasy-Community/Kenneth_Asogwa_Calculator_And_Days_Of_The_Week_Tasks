using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassOne
    {
       public enum DayOfWeek
        {

            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday


        }

        public static void DaysOfTheWeek(int dayNumber)
        {
            try
            {
                if (dayNumber >= 1 && dayNumber <= 7)
                {
                    DayOfWeek day = (DayOfWeek)dayNumber;
                    Console.WriteLine("The corresponding day of the week is: " + day);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occurred: " + e.Message);

            }

        }


    }
}
