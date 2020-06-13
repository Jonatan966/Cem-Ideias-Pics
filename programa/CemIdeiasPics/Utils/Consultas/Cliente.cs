using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CemIdeiasPics.Utils.Consultas
{
    public partial class Cliente
    {
        [JsonProperty("CLICPF")]
        public string CLICPF { get; set; }
        [JsonProperty("CLINOME")]
        public string CLINOME { get; set; }
        [JsonProperty("CLISEXO")]
        public string CLISEXO { get; set; }
        [JsonProperty("CLIDATANASCIMENTO")]
        public string CLIDATANASCIMENTO { get; set; }
        [JsonProperty("CLITELEFONE")]
        public string CLITELEFONE { get; set; }
        [JsonProperty("CLIEMAIL")]
        public string CLIEMAIL { get; set; }
        [JsonProperty("CLINUMEROCASA")]
        public string CLINUMEROCASA { get; set; }
        [JsonProperty("CLICEP")]
        public string CLICEP { get; set; }
    }
}
