using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppForAscendixTechnologies;
using System.Collections.Generic;
using System.Text.Json;


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
            personModel.CreateJson(personModel);
            PersonModel personModelResponse = await personModel.ReadJson();
            int expected = oneMillionOfPerson;
            int result = personModelResponse.modules.Count;
            Assert.AreEqual(expected, result);
        }
    }
}
