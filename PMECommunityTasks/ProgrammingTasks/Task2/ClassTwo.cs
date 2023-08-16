using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassTwo
    {
      public static void DaysOfTheWeek(int dayNumber1, int dayNumber2, int dayNumber3)
        {
            Dictionary<DayOfWeek, int> dayCount = new Dictionary<DayOfWeek, int>();

            int[] inputs = { dayNumber1, dayNumber2, dayNumber3 };
            try
            {

                foreach (int input in inputs)
                {
                    if (input >= 1 && input <= 7)
                    {
                        DayOfWeek day = (DayOfWeek)input;
                        //Console.WriteLine("The corresponding day of the week is: " + day);
                        if (dayCount.ContainsKey(day))
                        {

                            dayCount[day]++;

                        }
                        else
                        {
                            dayCount[day] = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 7");
                    }
                }

                foreach (var entry in dayCount)
                {
                    Console.WriteLine("Dictionary: key - {0}, Value - {1}", entry.Key, entry.Value);
                }

                // Calling the first method with the second input             
                if (dayNumber2 >= 1 && dayNumber2 <= 7)
                {
                    ClassOne.DaysOfTheWeek(dayNumber2);
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
