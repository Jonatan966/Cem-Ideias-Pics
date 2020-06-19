using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CemIdeiasPics.Utils.Consultas
{
    public class Portifolio
    {
        [JsonProperty("nomeImagem")]
        public string NomeImagem { get; set; }
        [JsonProperty("imagem")]
        public string Imagem { get; set; }
    }
}
