using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoNpgJson
{
    public class JsonThingy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JsonDocument JSONStuff { get; set; }
    }
}
