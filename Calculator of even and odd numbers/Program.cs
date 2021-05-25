using System;
using System.Collections.Generic;

namespace Calculator_of_even_and_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ShowErrorMessage(string mes)
            {
                Console.WriteLine(mes + " true/false");
                string boolStr = Console.ReadLine();
                bool userResponse;
                if (bool.TryParse(boolStr, out userResponse))
                {
                    if (userResponse)
                    {
                        RestartTheApp();
                    }
                }
            }

            static void RestartTheApp()
            {
                Console.WriteLine("This is the program where user can take the count of the odd and even numbers in current range! To do it you must enter min number, max number, type of numbers (odd/even) to create the range and enjoy the result!)");

                Console.WriteLine("You must enter min number: ");
                string minNumbStr = Console.ReadLine();
                Console.WriteLine("You must enter max number: ");
                string maxNumbStr = Console.ReadLine();

                Console.WriteLine("Odd/Even number you want to count?");
                string numberTypeStr = Console.ReadLine();
                string numberType = numberTypeStr.ToLower().Trim();

                int minNumber;
                int maxNumber;

                int totalSummary = 0;

                if (int.TryParse(minNumbStr, out minNumber) && int.TryParse(maxNumbStr, out maxNumber))
                {
                    void CountNumbers(string numberType)
                    {
                        List<int> numbersList = new List<int>();
                        for (int i = minNumber; i <= maxNumber; i++)
                        {
                            bool IsCurrentNumber = numberType == "odd" ? (i % 2) != 0 : (i % 2) == 0;
                            if (IsCurrentNumber)
                            {
                                numbersList.Add(i);
                            }
                        }
                        for (int j = 0; j <= numbersList.Count - 1; j++)
                        {
                            totalSummary += numbersList[j];
                        }
                        Console.WriteLine("You've got " + numbersList.Count + " " + numberType + " " +
                            "numbers counted!");
                        Console.WriteLine("The summary of it is: " + totalSummary);
                    }
                    if (numberType == "odd")
                    {
                        CountNumbers(numberType);
                    }
                    else if (numberType == "even")
                    {
                        CountNumbers(numberType);
                    }
                    else
                    {
                        ShowErrorMessage("You must enter: odd/even. Do you want to continue?");
                    }
                }
                else
                {
                    ShowErrorMessage("You've probably entered not numbers to create the range! Do you want to restart the app?");
                }
            }

            RestartTheApp();

            // You can do the summary of the counted numbers!
        }
    }
}
