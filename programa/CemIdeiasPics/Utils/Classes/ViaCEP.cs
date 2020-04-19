using Newtonsoft.Json;
using System.Net;
namespace CemIdeiasPics.Utils.Classes
{
    public static class ViaCEP
    {
        private static string URL { get; } = "http://cep.republicavirtual.com.br/web_cep.php?cep={0}&formato=json";
        public static CEP BuscarCEP(string CEP)
        {
            var result = string.Empty;
            using (var webClient = new WebClient())
            {
                result = webClient.DownloadString(string.Format(URL, CEP));
            }
            return JsonConvert.DeserializeObject<CEP>(result);
        }

        public class CEP
        {
            [JsonProperty("resultado")]
            public string Resultado { get; set; }

            [JsonProperty("resultado_txt")]
            public string ResultadoTxt { get; set; }

            [JsonProperty("uf")]
            public string Uf { get; set; }

            [JsonProperty("cidade")]
            public string Cidade { get; set; }

            [JsonProperty("bairro")]
            public string Bairro { get; set; }

            [JsonProperty("tipo_logradouro")]
            public string TipoLogradouro { get; set; }

            [JsonProperty("logradouro")]
            public string Logradouro { get; set; }
        }
    }
}
