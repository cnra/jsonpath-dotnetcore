using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace jsonpath_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = File.ReadAllText("data.json");
            JObject js = JObject.Parse(txt);
            var res = js.SelectToken("$.header.components[?(@.id=='chapterHeaderVersion')].value");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
