using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Online
{
    public class ConectaCEP
    {
        private static string URL { get; } = "http://cep.republicavirtual.com.br/web_cep.php?cep={0}&formato=json";
        public static async Task<CEP> BuscarCEP(string CEP)
        {
            var result = string.Empty;
            using (var webClient = new WebClient())
            {
                await Task.Run(() => result = webClient.DownloadString(string.Format(URL, CEP)));
            }
            return JsonConvert.DeserializeObject<CEP>(result);
        }

        public class CEP
        {
            [JsonProperty("resultado", NullValueHandling = NullValueHandling.Ignore)]
            public string Resultado { get; set; }

            [JsonProperty("resultado_txt", NullValueHandling = NullValueHandling.Ignore)]
            public string ResultadoTxt { get; set; }

            [JsonProperty("uf", NullValueHandling = NullValueHandling.Ignore)]
            public string Uf { get; set; }

            [JsonProperty("cidade", NullValueHandling = NullValueHandling.Ignore)]
            public string Cidade { get; set; }

            [JsonProperty("bairro", NullValueHandling = NullValueHandling.Ignore)]
            public string Bairro { get; set; }

            [JsonProperty("tipo_logradouro", NullValueHandling = NullValueHandling.Ignore)]
            public string TipoLogradouro { get; set; }

            [JsonProperty("logradouro", NullValueHandling = NullValueHandling.Ignore)]
            public string Logradouro { get; set; }
        }
    }
}
