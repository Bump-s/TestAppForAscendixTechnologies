using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace TestAppForAscendixTechnologies
{
    class JsonFunctionality
    {
        public async Task CreateJson(PersonModel model)
        {

            var option = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(model, option);
            string path = @"persons.json";
            File.WriteAllText(path, json);
        }

        public async Task<PersonModel> ReadJson()
        {
            PersonModel personModel;

            using (var streamReader = new StreamReader("persons.json"))
            {
                string json = streamReader.ReadToEnd();
                personModel = JsonSerializer.Deserialize<PersonModel>(json);
            }

            return personModel;
        }
    }
}