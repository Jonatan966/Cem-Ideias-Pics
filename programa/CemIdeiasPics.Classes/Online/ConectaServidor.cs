using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Online
{
    public enum TipoEnvio { ComandoSQL, Imagem }
    public static class ConectaServidor
    {
        public static string urlAddress = "https://cemideias-pics.000webhostapp.com/src/php/";
        private static string pwd = "7fe182bcddb67905fbd39db957e23116";
        private static string[] tipoEnvioPg = new string[] { "ConexaoMySQL", "EnviaImagem" };

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
                    pagesource = Encoding.UTF8.GetString(await Task.Run(() =>
                    {
                        try
                        {
                            return client.UploadValues(urlAddress + tipoEnvioPg[(int)tipoEnvio] + ".php", postData);
                        }
                        catch
                        {
                            return new byte[] { };
                        }
                    }));
                    return pagesource;
                }
            }
            catch { return pagesource; }
        }
    }
}
