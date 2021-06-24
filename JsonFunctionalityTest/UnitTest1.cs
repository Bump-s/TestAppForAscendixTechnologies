using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppForAscendixTechnologies;
using System.Collections.Generic;


namespace JsonFunctionalityTest
{
    [TestClass]
    public class UnitTest1
    {
        int oneMillionOfPerson = 1000000;
        [TestMethod]
        public async void CreateJson_AddOneMillionPerson()
        {
            PersonModel personModel = new PersonModel();
            personModel.modules = new Queue<Person>();

            for (int i = 0; i < oneMillionOfPerson; i++)
            {
                personModel.modules.Enqueue(new Person("John", 25));
            }

            await personModel.CreateJson(personModel);
            PersonModel personModelResponse = await personModel.ReadJson();

            int expected = oneMillionOfPerson;
            int result = personModelResponse.modules.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async void ReadJson_CheckForCorrectTypeOfObject()
        {
            PersonModel personModel = new PersonModel();
            personModel.modules = new Queue<Person>();
            personModel.modules.Enqueue(new Person("John", 25));

            await personModel.CreateJson(personModel);
            PersonModel personModelResponse = await personModel.ReadJson();
            
            Person checkPersonResult;
            checkPersonResult = personModelResponse.modules.Dequeue();

            Assert.AreEqual(typeof(Person), checkPersonResult.GetType());
        }
    }
}
