using ExamenHansOrtiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExamenHansOrtiz.Services
{
    public class HO_APIService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://678dab63a64c82aeb11da64b.mockapi.io/CallesdeQuito";

        public HO_APIService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<HO_Calle>> GetCallesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(ApiUrl);
                var calles = JsonConvert.DeserializeObject<List<HO_Calle>>(response);
                return calles;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener datos de la API: {ex.Message}");
                return new List<HO_Calle>();
            }
        }
    }
}

