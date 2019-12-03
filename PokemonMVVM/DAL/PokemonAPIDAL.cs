using Newtonsoft.Json;
using PokemonMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMVVM.DAL
{
    public static class PokemonAPIDAL
    {
        const string LOADALL_URL = "https://pokeapi.co/api/v2/";
        public static async Task<List<Pokemon>> LoadPokemons()
        {
            WebClient wc = new WebClient();
            byte[] data = await wc.DownloadDataTaskAsync(new Uri(LOADALL_URL));
            string json = Encoding.UTF8.GetString(data);
            PokemonAPIResult result = JsonConvert.DeserializeObject<PokemonAPIResult>(json);
        }
    }
}
