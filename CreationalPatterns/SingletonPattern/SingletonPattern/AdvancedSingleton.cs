using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace SingletonPattern
{
    public sealed class AdvancedSingleton
    {
        public static readonly AdvancedSingleton Instance = new AdvancedSingleton();
        private Dictionary<string, object> keyValuePairs;

        private AdvancedSingleton()
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "configuration.json");
            string config = File.ReadAllText(fullPath);
            this.keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, object>>(config);
        }
        public object this[string key]
        {
            get
            {
                return this.keyValuePairs[key];
            }
        }

        public void PrintKeyAndValue()
        {
            foreach (var pair in this.keyValuePairs)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }
        }
    }
}
