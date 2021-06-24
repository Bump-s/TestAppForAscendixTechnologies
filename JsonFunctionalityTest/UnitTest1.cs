using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppForAscendixTechnologies;
using System.Collections.Generic;


namespace JsonFunctionalityTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateJson_AddOneHundredThousandPerson()
        {
            int oneMillionOfPerson = 1000000;
            Person person = new Person("John", 25);
            PersonModel personModel = new PersonModel();
            personModel.modules = new Queue<Person>();

            for (int i = 0; i < oneMillionOfPerson; i++)
            {
                personModel.modules.Enqueue(new Person("John", 25));
            }
            int expected = oneMillionOfPerson;
            int result = personModel.modules.Count;
            Assert.AreEqual(expected, result);
        }

        public void As()
        {

        }
    }
}
