using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoNpgJson
{
    class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection.GlobalTypeMapper.UseJsonNet();
            var db = new DatabaseContext();
            if (!db.JsonThingies.Any())
            {
                db.JsonThingies.Add(new JsonThingy() { Id = 1, Name = "Stuff", JSONStuff = JsonDocument.Parse("{\"Sometihng\": \"Somethingelse\"}") });
                db.SaveChanges();
                db = new DatabaseContext(); // Make sure it's not cached...
            }

            var theThing = db.JsonThingies.FirstOrDefault();
            Console.WriteLine("Ended");
            Console.ReadLine();
        }
    }
}
