
using Newtonsoft.Json.Linq;
using PokemonApiProject.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace PokemonApiProject
{
    public static class APIRepository
    {
        public static PokemonInfo GetPokemonName(string pokemonName)
        {
            var api = System.IO.File.ReadAllText("api.txt");

            var url = $"https://pokeapi.co/api/v2/pokemon/bulbasuar{pokemonName}?api_key={api}";

            var client = new RestClient(url);

            var request = new RestRequest(pokemonName);

            var response = client.Execute(request);

            var data = JObject.Parse(response.Content);

            var pokemon = new PokemonInfo();

            return pokemon;
        }


        public static PokemonInfo GetHeldItem(string HeldItem)
        {
            var api = System.IO.File.ReadAllText("api2.txt");

            var url = $"https://na1.api.riotgames.com/lol/league/v4/entries/by-summoner/{HeldItem}?api_key={api}";

            var client = new RestClient(url);

            var request = new RestRequest(HeldItem);

            var response = client.Execute(request);            

            var data = JObject.Parse(response.Content);

            var pokemon = new PokemonInfo();


            return pokemon;
        }

        public static PokemonInfo GetPokemonTyping(string pokemonTyping)
        {
            var api = System.IO.File.ReadAllText("api2.txt");

            var url = $"\"https://pokeapi.co/api/v2/type/1/{pokemonTyping}?api_key={api}";

            var client = new RestClient(url);

            var request = new RestRequest(pokemonTyping);

            var response = client.Execute(request);

            var data = JObject.Parse(response.Content);

            var pokemon = new PokemonInfo();

            return pokemon;
        }

        public static string GetPokemonAbility(string pokemonAbility)
        {
            var api = System.IO.File.ReadAllText("api2.txt");

            var url = $"https://pokeapi.co/api/v2/ability/150/{pokemonAbility}?api_key={api}";

            var client = new RestClient(url);

            var request = new RestRequest(pokemonAbility);

            var response = client.Execute(request);

            var data = JObject.Parse(response.Content).GetValue("data");

            var pokemon = new PokemonInfo();

            return pokemonAbility;
        }
    }
}
