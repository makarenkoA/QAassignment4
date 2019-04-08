using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAassignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            bool toRepeatProg = true;
            bool validYesNo = false;
            string userInputYN = "";
            int accidents = 0;
            bool validAccidents = false;
            string userAccidentsInput = "";
            int age = 0;
            bool validAge = false;
            string userAgeInput = "";
            int experience = 0;
            bool validExperience = false;
            string userExperienceInput = "";

            Console.WriteLine("This program is for calculating an insurance for a driver after answering a few questions\n");

            while (toRepeatProg == true)
            {
                Console.WriteLine("Are you a new driver? ('y'/'n'). To exit program write 'x'");
                userInputYN = Console.ReadLine();

                while (validYesNo == false)
                {
                    if (userInputYN != "y" || userInputYN != "n" || userInputYN != "x")
                        Console.WriteLine("Please, write 'y', 'n' or 'x' depending on the answer");
                    else
                        validYesNo = true;
                }

                if (userInputYN == "y")
                    Console.WriteLine("Your insurance will be 3000$");
                else if (userInputYN == "x")
                    toRepeatProg = false;
                else
                {
                    Console.WriteLine("How many car accidents did you have?");
                    userAccidentsInput = Console.ReadLine();

                    while (validAccidents == false)
                    {
                        bool result = int.TryParse(userAccidentsInput, out accidents);

                        if (result == false)
                        {
                            Console.WriteLine("Sorry, incorrect input, try again\n");
                        }
                        else if (accidents <= 0)
                        {
                            Console.WriteLine("Sorry, number should be more than 0\n");
                        }
                        else
                        {
                            validAccidents = true;
                        }
                    }

                    if (accidents >= 3)
                        Console.WriteLine("Sorry, we can't provide insurance for you");
                    else
                    {
                        Console.WriteLine("How old are you?");
                        userAgeInput = Console.ReadLine();

                        while (validAge == false)
                        {
                            bool resultAge = int.TryParse(userAgeInput, out age);

                            if (resultAge == false)
                            {
                                Console.WriteLine("Sorry, incorrect input, try again\n");
                            }
                            else if (age <= 0 || age > 100)
                            {
                                Console.WriteLine("Sorry, number should be more than 0 and less than 100\n");
                            }
                            else
                            {
                                validAge = true;
                            }
                        }

                        Console.WriteLine("How many years of driving experience do you have?");
                        userExperienceInput = Console.ReadLine();

                        while (validExperience == false)
                        {
                            bool resultExperience = int.TryParse(userExperienceInput, out experience);

                            if (resultExperience == false)
                            {
                                Console.WriteLine("Sorry, incorrect input, try again\n");
                            }
                            else if (experience <= 0 || experience > 100)
                            {
                                Console.WriteLine("Sorry, number should be more than 0 and less than 100\n");
                            }
                            else
                            {
                                validExperience = true;
                            }
                        }

                        if (age < 30)
                        {
                            if (experience <= 9)
                                Console.WriteLine("Your insurance will be 2000$");
                            else
                                Console.WriteLine("Your insurance will be 1000$");
                        }
                        else
                        {
                            if (experience < 2)
                                Console.WriteLine("Your insurance will be 2000$");
                            else if (experience <= 9)
                                Console.WriteLine("Your insurance will be 2000$ with 20% rate reduction - 1600$");
                            else
                                Console.WriteLine("Your insurance will be 1000$ with 20% rate reduction - 800$");
                        }
                    }
                }

                toRepeatProg = false;
            }
        }
    }
}


       
