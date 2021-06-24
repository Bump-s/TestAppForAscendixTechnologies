using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace TestAppForAscendixTechnologies
{
    public class Module
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("parameters")]
        public List<string> Parameters { get; set; }

        public Module(string[] parameters, string name)
        {
            Parameters = parameters.ToList();
            Name = name;
        }

        public void Execute()
        {
            Console.WriteLine($"Module {Name} executed with {string.Join(",", Parameters)}");
        }

    }
}