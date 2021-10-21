using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using testWebClient.Contracts;
using testWebClient.Model;

namespace testWebClient.Service
{
    public class LucaService: ILucasService
    {
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;
        private readonly string _uri;
        public LucaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
       
        }

        public async Task<Root> GetDataAsync()
        {
            var uri = "https://luca.spvie.com/Api/health";
            var responseString = await _httpClient.GetStringAsync(uri);
            Root root = JsonConvert.DeserializeObject<Root>(responseString);
            return root;
          
        }
     
    }
}
