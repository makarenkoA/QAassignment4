using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAassignment4
{
    public class Program
    {
        public static void Main(string[] args)
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
            string calculatedInsuranceNew = "";
            string calculatedInsuranceExperienced = "";

            Console.WriteLine("This program is for calculating an insurance for a driver after answering a few questions\n");

            while (toRepeatProg == true)
            {
                Console.WriteLine("Are you a new driver? ('y'/'n'). To exit program write 'x'");

                while (validYesNo == false)
                {
                    userInputYN = Console.ReadLine();

                    if (userInputYN != "y" && userInputYN != "n" && userInputYN != "x")
                    {
                        Console.WriteLine("Please, write 'y', 'n' or 'x' depending on the answer");
                    }
                    else
                    {
                        validYesNo = true;
                    }
                }

                if (userInputYN == "x")
                    toRepeatProg = false;
                else if (userInputYN == "y")
                {
                    calculatedInsuranceNew = "3000";
                    Console.WriteLine("Your calculated insurance will be " + calculatedInsuranceNew + ".00$.");
                    toRepeatProg = false;
                }
                else
                {
                    Console.WriteLine("How many car accidents did you have?");

                    while (validAccidents == false)
                    {
                        userAccidentsInput = Console.ReadLine();
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

                        while (validAge == false)
                        {
                            userAgeInput = Console.ReadLine();
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

                        while (validExperience == false)
                        {
                            userExperienceInput = Console.ReadLine();
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
                        calculatedInsuranceExperienced = InsuranceCalculatorHelper.CalculatedInsuranceForExperiencedDriver(age, experience);
                        Console.WriteLine("Your calculated insurance will be " + calculatedInsuranceExperienced + ".00$.");
                    }
                }
                toRepeatProg = false;
            }
        }
    }
}


       
