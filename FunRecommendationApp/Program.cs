using System;

namespace FunRecommendationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of inputs and declare and initialize input and output variables
            string[] activityList = new string[5] { null, "Action", "Chilling", "Danger", "Good Food" };
            string groupSizeString = "";
            string activityString = "";
            string activityName = "";
            string transportation = "";

            // Greet user and get user input for desired activity
            Console.WriteLine("Hello User, welcome to the 'Fun Recommendation' program! What are you in the mood for?");
            Console.WriteLine("Here are your options: ");
            Console.WriteLine("1) " + activityList[1]);
            Console.WriteLine("2) " + activityList[2]);
            Console.WriteLine("3) " + activityList[3]);
            Console.WriteLine("4) " + activityList[4]);
            activityString = Console.ReadLine();
            int activityNumber = Convert.ToInt32(activityString);

            // Get user input for number of people input to suggest transportation and convert to int 
            Console.WriteLine("How many people are you bringing with you?");
            groupSizeString = Console.ReadLine();
            int groupSizeNumber = Convert.ToInt32(groupSizeString);

            // Create Switch statment for activity input
            switch (activityNumber)
            {
                case 1:
                    activityName = "stock car racing";
                    break;
                case 2:
                    activityName = "hiking";
                    break;
                case 3:
                    activityName = "skydiving";
                    break;
                case 4:
                    activityName = "to Taco Bell";
                    break;
                default:
                    activityName = "Input was not understood. Please choose a valid option.";
                    break;
            }

            // Create if statement for numberOfPeople input
            if (groupSizeNumber == 0)
            {
                transportation = "sneakers";
            }
            else if (groupSizeNumber >= 1 && groupSizeNumber <= 4)
            {
                transportation = "a sedan";
            }
            else if (groupSizeNumber >= 5 && groupSizeNumber <= 10)
            {
                transportation = "a Volkswagen bus";
            }
            else if (groupSizeNumber >= 11)
            {
                transportation = "an airplane";
            }
            else
            {
                transportation = "Input was not understood. Please choose a valid option.";
            }

            // Create output variable and print suggested activty and transportation mode for user
            Console.WriteLine("Okay, if you're in the mood for " + activityList[activityNumber] + ", then you should go " + activityName + " and travel in " + transportation + "!");
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
