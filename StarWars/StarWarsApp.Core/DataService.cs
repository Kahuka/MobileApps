using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    public class DataService
    {
        public static async Task<Films> GetStarWarsFilms(string queryString)
        {
            //var query = "https://swapi.co/api/films/";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Films data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Films>(response);
                return data;
            }
            return null;
        }

        public static async Task<People> GetStarWarsPeople(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            People data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<People>(response);
                return data;
            }
            return null;
        }

        public static async Task<Planets> GetStarWarsPlanets(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Planets data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Planets>(response);
                return data;
            }
            return null;
        }

        public static async Task<Starships> GetStarWarsStarships(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Starships data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Starships>(response);
                return data;
            }
            return null;
        }
    }
}
