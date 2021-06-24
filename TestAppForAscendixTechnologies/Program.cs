using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestAppForAscendixTechnologies
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PersonModel personModel = new PersonModel();
            personModel.modules = new Queue<Person>();
            personModel.modules.Enqueue(new Person("John", 21));
            personModel.modules.Enqueue(new Person("Bob", 17));
            personModel.modules.Enqueue(new Person("Sara", 36));

            //var jsonFunctionality = new JsonFunctionality();

            await personModel.CreateJson(personModel);

            PersonModel personModelResponse = await personModel.ReadJson();

            Console.ReadLine();
        }
    }
}