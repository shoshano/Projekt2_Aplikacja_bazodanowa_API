using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using StarWars.Data;

namespace Projekt2_Aplikacja_bazodanowa_API
{
    internal class APITest
    {
        public HttpClient Client { get; set; }
        public async Task GetData()
        {
            Client = new HttpClient();
            string call = "https://swapi.dev/api/";
            string response = await Client.GetStringAsync(call);
            List<Root> students = JsonSerializer.Deserialize<List<Root>>(response);
            foreach(var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            
        }
    }
}
