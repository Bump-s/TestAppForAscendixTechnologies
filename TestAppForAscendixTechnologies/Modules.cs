using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace TestAppForAscendixTechnologies
{
    public class Modules
    {
        public List<Module> ModuleList { get; set; }

        public Modules(string path = @"modules.json")
        {
            ModuleList = ReadJson(path);
        }

        private List<Module> ReadJson(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                string json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Module>>(json);
            }
        }

        public void ExecutedAll()
        {
            foreach (var item in ModuleList)
            {
                item.Execute();
            }
        }
    }
}