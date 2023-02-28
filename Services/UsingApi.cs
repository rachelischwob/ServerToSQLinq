using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsingApi
    {
        //url=api-sq.azurewebsites.net

        public  Person AddId(Person p)
        {
            // HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://api-sq.azurewebsites.net/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = await client.PostAsJsonAsync<Person>("person", p);
            //if (response.IsSuccessStatusCode)
            //{
            //    var v = response.Content.ReadAsStringAsync();
            //    p.Id = v.Result.
            //}

            return p;
        }
    }
}
