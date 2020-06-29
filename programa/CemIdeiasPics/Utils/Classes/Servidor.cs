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
                    pagesource = Encoding.UTF8.GetString(await Task.Run(() => {
                        try
                        {
                            return client.UploadValues(urlAddress+tipoEnvioPg[(int)tipoEnvio]+".php", postData);
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

        public class PortifolioLoader
        {
            public Portifolio[] portifolio;
            
            public async Task CarregaImagens(string ensaioID)
            {
                string response = await EnviarItem("", $"{ensaioID}|recebe", TipoEnvio.Imagem);
                portifolio = JsonConvert.DeserializeObject<Portifolio[]>(response);
                if (portifolio.Length > 0)
                {
                    CarregaImagem(0);
                }
            }

            public Image CarregaImagem(int pos)
            {
                if (portifolio.Length > 0)
                    return Manipuladores.ConverteBase64ParaImagem(portifolio[pos].Imagem);
                else return (Properties.Resources.none);
            }

            public async Task AdicionaImagem(string filename, string ensaioID)
            {
                string img = Manipuladores.ConverteImagemParaBase64(filename);
                await EnviarItem(img, $"{ensaioID}|envia", TipoEnvio.Imagem);
                await CarregaImagens(ensaioID);
            }

            public async Task ExcluiImagem(int img, string ensaioID, bool carregaImgs = true)
            {
                if (portifolio.Length > 0)
                {
                    if (bool.Parse(await EnviarItem(portifolio[img].NomeImagem, $"{ensaioID}|exclui", TipoEnvio.Imagem)))
                    {
                        Mensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                        if (carregaImgs) await CarregaImagens(ensaioID);
                    }
                    else
                    {
                        Mensagens.MostrarMensagem(MensagensPredefinidas.ERRO_INESPERADO);
                    }
                }
            }

            public async Task AlteraImagem(int imgAtual, string novaImg, string ensaioID)
            {
                await ExcluiImagem(imgAtual, ensaioID, false);
                await AdicionaImagem(novaImg, ensaioID);
            }
        }
    }
}
