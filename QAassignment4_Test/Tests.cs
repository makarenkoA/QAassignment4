using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAassignment4;
using NUnit.Framework;

namespace QAassignment4_tests
{
    [TestFixture]
    class QAassignment4_tests
    {
        [Test]
        public void CalculatedInsuranceForExperiencedDriver_input23x5_expectedResultEquals2000()
        {
            int age = 23;
            int experience = 5;
            string expectedResult = "2000";

            string result = InsuranceCalculatorHelper.CalculatedInsuranceForExperiencedDriver(age, experience);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatedInsuranceForExperiencedDriver_input29x11_expectedResultEquals1000()
        {
            int age = 29;
            int experience = 11;
            string expectedResult = "1000";

            string result = InsuranceCalculatorHelper.CalculatedInsuranceForExperiencedDriver(age, experience);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatedInsuranceForExperiencedDriver_input40x7_expectedResultEquals1600()
        {
            int age = 40;
            int experience = 7;
            string expectedResult = "1600";

            string result = InsuranceCalculatorHelper.CalculatedInsuranceForExperiencedDriver(age, experience);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatedInsuranceForExperiencedDriver_input53x20_expectedResultEquals800()
        {
            int age = 53;
            int experience = 20;
            string expectedResult = "800";

            string result = InsuranceCalculatorHelper.CalculatedInsuranceForExperiencedDriver(age, experience);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatedInsuranceForExperiencedDriver_input37x1_expectedResultEquals2000()
        {
            int age = 37;
            int experience = 1;
            string expectedResult = "2000";

            string result = InsuranceCalculatorHelper.CalculatedInsuranceForExperiencedDriver(age, experience);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
