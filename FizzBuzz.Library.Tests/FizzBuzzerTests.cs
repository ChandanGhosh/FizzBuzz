using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1,2,4,7,8,11,13,14,16,17,19)] int input)
        {
            //Assign
            //int input = 1;

            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual(input.ToString(), output);
        }

        

        [Test]
        public void Buzzer_When3_ReturnsFizz([Values(3,6,9,12,18)] int input)
        {
            
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When5_ReturnBuzz([Values(5,20)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5AndDiv3_ReturnFizzBuzz([Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }

    }
}
