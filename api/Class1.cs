using System;
using System.Net.Http;

namespace api
{
    public class Class1
    {

        public string async private getApiInfo()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync("https://api.spotify.com/v1/albums");

           response.EnsureSuccessStatusCode();

            return "response";
        }
 
    }
}
