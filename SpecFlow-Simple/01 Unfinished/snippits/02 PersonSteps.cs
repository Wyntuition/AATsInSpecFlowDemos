using System;
using Demo.Simple.AAT;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Specs
{
    [Binding]
    public class PersonSteps
    {
        private Person _person;
        private int _calculatedAge;

        [Given(@"I have entered ""(.*)"" with a birthday of I have entered ""(.*)""")]
        public void GivenIHaveEnteredWithABirthdayOfIHaveEntered(string p0, string p1)
        {
            _person = new Person(p0, DateTime.Parse(p1));
        }

        [When(@"I calculate age")]
        public void WhenICalculateAge()
        {
            _calculatedAge = _person.CalculateAge();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int age)
        {
            Assert.That(_calculatedAge == age);
        }
    }
}
