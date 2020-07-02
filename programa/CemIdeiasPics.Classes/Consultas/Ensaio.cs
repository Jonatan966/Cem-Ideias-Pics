using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Consultas
{
    public class Ensaio
    {
        [JsonProperty("ENSID")]
        public string Ensid { get; set; }

        [JsonProperty("ENSCLIENTE")]
        public string Enscliente { get; set; }

        [JsonProperty("ENSUSUARIO")]
        public string Ensusuario { get; set; }

        [JsonProperty("ENSTIPO")]
        public string Enstipo { get; set; }

        [JsonProperty("ENSCEP")]
        public string Enscep { get; set; }

        [JsonProperty("ENSNUMLOCAL")]
        public string Ensnumlocal { get; set; }

        [JsonProperty("ENSDATA")]
        public string Ensdata { get; set; }

        [JsonProperty("ENSPRECO")]
        public string Enspreco { get; set; }

        [JsonProperty("ENSDIRETORIO")]
        public string Ensdiretorio { get; set; }
    }
    public class TipoEnsaio
    {
        [JsonProperty("TPEID")]
        public string ID { get; set; }
        [JsonProperty("TPETIPO")]
        public string Tipo { get; set; }
    }

}
