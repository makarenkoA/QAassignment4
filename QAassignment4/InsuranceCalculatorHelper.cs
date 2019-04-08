using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAassignment4
{
    public static class InsuranceCalculatorHelper
    {
        public static string CalculatedInsuranceForExperiencedDriver(int age, int experience)
        {
            string result = "";

            if (age < 30)
            {
                if (experience <= 9)
                    result = "2000";
                else
                    result = "1000";
            }
            else
            {
                if (experience < 2)
                    result = "2000";
                else if (experience <= 9)
                    result = "1600";
                else
                    result = "800";
            }

            return result;
        }
    }
}
