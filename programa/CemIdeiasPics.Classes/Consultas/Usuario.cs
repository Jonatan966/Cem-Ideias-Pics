using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Consultas
{
    public partial class Usuario
    {
        [JsonProperty("USUID")]
        public string USUID { get; set; }
        [JsonProperty("USUCPF")]
        public string USUCPF { get; set; }

        [JsonProperty("USUNOME")]
        public string USUNOME { get; set; }
        [JsonProperty("USUSEXO")]
        public string USUSEXO { get; set; }
        [JsonProperty("USUTELEFONE")]
        public string USUTELEFONE { get; set; }
        [JsonProperty("USULOGIN")]
        public string USULOGIN { get; set; }
        [JsonProperty("USUBLOQUEIO")]
        public string USUBLOQUEIO { get; set; }
        [JsonProperty("USUEMAIL")]
        public string USUEMAIL { get; set; }

        [JsonProperty("USUIMG")]
        public string USUIMG { get; set; }
        [JsonProperty("USUTIPO")]
        public string USUTIPO { get; set; }
    }

}
