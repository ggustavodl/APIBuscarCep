using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaCEPWF_1
{
    internal class CepResponse
    {
        [JsonProperty("cep")]

        public string Cep { get; set; }
        [JsonProperty("Logradouro")]

        public string Logradouro { get; set; }
        [JsonProperty("complemento")]

        public string Complemento { get; set; }
        [JsonProperty("bairro")]

        public string Bairro { get; set; }
        [JsonProperty("Localidade")]

        public string Localidade { get; set; }
        [JsonProperty("uf")]

        public string Uf { get; set; }
        [JsonProperty("unidade")]

        public string Ibge { get; set; }
        [JsonProperty("gia")]

        public string Gia { get; set; }
    }
    
       
    
}
