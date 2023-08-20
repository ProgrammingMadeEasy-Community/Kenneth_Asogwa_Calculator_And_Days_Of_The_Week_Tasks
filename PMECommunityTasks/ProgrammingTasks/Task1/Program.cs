using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
      static void SimpleCalculator()
        {
            try
            {
                do
                {

                    double num1, num2;
                    char operation;
                    double result = 0;

                    int trialCount = 0;
                    int maxTrial = 5;

                    while (true)
                    {
                        
                        Console.Write("Enter the first number: ");
                        if (double.TryParse(Console.ReadLine(), out num1))
                            break;

                        trialCount++;
                        if (trialCount >= maxTrial)
                        {
                            Console.WriteLine("Invalid number");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            return;
                        }
                    }

                    trialCount = 0;
                    while (true)
                    {
                        Console.Write("Enter the second number: ");
                        if (double.TryParse(Console.ReadLine(), out num2))
                            break;

                        trialCount++;
                        if (trialCount >= maxTrial)
                        {
                            Console.WriteLine("Invalid number");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            return;
                        }
                    }

                    trialCount = 0;
                    while (true)
                    {
                        Console.WriteLine("You can perform the following operations:");
                        Console.WriteLine("1 = Addition");
                        Console.WriteLine("2 = Subtraction");
                        Console.WriteLine("3 = Multiplication");
                        Console.WriteLine("4 = Division");

                        Console.Write("Choose a number for operation: ");

                        if (char.TryParse(Console.ReadLine(), out operation))
                        {
                            if (operation == '1' || operation == '2' || operation == '3' || operation == '4')
                                break;
                        }

                        trialCount++;
                        if (trialCount >= maxTrial)
                        {
                            Console.WriteLine("Invalid operation");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            return;
                        }
                    }

                    switch (operation)
                    {
                        case '1':
                            result = num1 + num2;
                            operation = '+';
                            break;
                        case '2':
                            result = num1 - num2;
                            operation = '-';
                            break;
                        case '3':
                            result = num1 * num2;
                            operation = '*';
                            break;
                        case '4':
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("Division by zero is not allowed.");
                                Console.ReadKey();
                            }
                            operation = '/';
                            break;
                        default:
                            Console.WriteLine("Invalid operation.");
                            return;
                    }

                    Console.WriteLine("Result: ({0} {1} {2}) = {3}", num1, operation, num2, result);

                    Console.Write("Do you want to perform another operation? (Y/N): ");
                }
                while (Console.ReadLine().ToUpper() == "Y");

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);

            }

        }
        static void Main(string[] args)
        {
            SimpleCalculator();
        }
    }
}
