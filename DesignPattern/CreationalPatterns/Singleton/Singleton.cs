using DesignPattern.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPattern.CreationalPatterns.Singleton
{
    public sealed class Singleton
    {
        public static readonly Singleton Instance = new Singleton();
        private readonly Dictionary<string, object> config;
        private Singleton()
        {
            var configJsonPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CreationalPatterns\Singleton\appsettings.json");
            if (!File.Exists(configJsonPath))
            {
                throw new FileNotFoundException();
            }
            using (var streamReader = new StreamReader(configJsonPath))
            {
                string jsonStr = streamReader.ReadToEnd();
                config = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonStr);
            }
        }

        public object this[string key]
        {
            get
            {
                if (!this.config.ContainsKey(key))
                {
                    throw new IndexOutOfRangeException();
                }

                return JsonConvert.DeserializeObject<EmailSetting>(config[key].ToString());
            }
        }

        public List<string> Keys { get { return this.config.Keys.ToList(); } }
    }
}
