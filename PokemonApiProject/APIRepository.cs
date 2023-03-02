using PokemonApiProject.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;


namespace PokemonApiProject.Models
{
    
    public static class APIRepository
    {
        public static Root GetPokemonInfo(string pokemonName)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/?offset=0&limit=151").Result;
            var root = JsonConvert.DeserializeObject<Root>(response);

            return root;
        }

         

    }
}





