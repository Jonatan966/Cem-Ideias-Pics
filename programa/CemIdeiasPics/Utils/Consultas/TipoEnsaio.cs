using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CemIdeiasPics.Utils.Consultas
{
    class TipoEnsaio
    {
        [JsonProperty("TPEID")]
        public string ID { get; set; }
        [JsonProperty("TPETIPO")]
        public string Tipo { get; set; }
    }
}
