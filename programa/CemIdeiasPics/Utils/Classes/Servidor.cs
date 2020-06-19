using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using CemIdeiasPics.Utils.Consultas;
using Newtonsoft.Json;
using System.Drawing;

namespace CemIdeiasPics.Utils.Classes
{
    public enum TipoEnvio { ComandoSQL, Imagem}
    class Servidor
    {
        public static string urlAddress = "http://cemideias-pics.000webhostapp.com/src/php/";
        private protected static string pwd = "7fe182bcddb67905fbd39db957e23116";


        public static async Task<string> EnviarItem(string item, string opcional = "", TipoEnvio tipoEnvio = TipoEnvio.ComandoSQL)
        {
            string pagesource = "false";
            try
            {
                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                            { "acesso", pwd },  //order: {"parameter name", "parameter value"}
                            { "cmd", item },
                            { "opt", opcional }
                    };
                    pagesource = Encoding.UTF8.GetString(await Task.Run(() => {
                        try
                        {
                            return client.UploadValues(urlAddress+
                                (tipoEnvio==TipoEnvio.ComandoSQL? "ConexaoMySQL.php":"EnviaImagem.php"),        postData);
                        }
                        catch
                        {
                            return new byte[] { };
                        }
                    }));
                    return pagesource;
                }
            }
            catch
            {
                return pagesource;
            }
        }
    }
}
