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

        [JsonProperty("USUNOME")]
        public string USUNOME { get; set; }

        [JsonProperty("USUIMG")]
        public string USUIMG { get; set; }
    }

}
