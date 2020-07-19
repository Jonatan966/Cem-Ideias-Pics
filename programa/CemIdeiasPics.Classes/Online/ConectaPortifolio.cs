using CemIdeiasPics.Classes.Manipuladores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Online
{
    public class ConectaPortifolio
    {
        public Portifolio[] portifolio;

        public async Task CarregaImagens(string ensaioID)
        {
            string response = await ConectaServidor.EnviarItem("", $"{ensaioID}|recebe", TipoEnvio.Imagem);
            portifolio = JsonConvert.DeserializeObject<Portifolio[]>(response);
            if (portifolio.Length > 0)
            {
                CarregaImagem(0);
            }
        }

        public Image CarregaImagem(int pos)
        {
            if (portifolio.Length > 0)
                return ManipulaImagem.ConverteBase64ParaImagem(portifolio[pos].Imagem);
            else return null;
        }

        public async Task AdicionaImagem(string filename, string ensaioID)
        {
            string img = ManipulaImagem.ConverteImagemParaBase64(filename);
            await ConectaServidor.EnviarItem(img, $"{ensaioID}|envia", TipoEnvio.Imagem);
            await CarregaImagens(ensaioID);
        }

        public static async Task<Image> BaixaImagem(string imgName, int id)
        {
            string imgBase64 = await ConectaServidor.EnviarItem(imgName, $"{id}|baixa", TipoEnvio.Imagem);
            return ManipulaImagem.ConverteBase64ParaImagem(imgBase64);
        }

        public static async Task<string> EnviaImagem(string imgCaminho, int id)
        {
            string imgBase64 = ManipulaImagem.ConverteImagemParaBase64(imgCaminho);
            return await ConectaServidor.EnviarItem(imgBase64, $"{id}|envia", TipoEnvio.Imagem);
        }

        public async Task ExcluiImagem(int img, string ensaioID, bool carregaImgs = true)
        {
            if (portifolio.Length > 0)
            {
                if (bool.Parse(await ConectaServidor.EnviarItem(portifolio[img].NomeImagem, $"{ensaioID}|exclui", TipoEnvio.Imagem)))
                {
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                    if (carregaImgs) await CarregaImagens(ensaioID);
                }
                else
                {
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.ERRO_INESPERADO);
                }
            }
        }

        public static async Task ExcluiPortifolio(string ensaioID)
        {
            if (bool.Parse(await ConectaServidor.EnviarItem(string.Empty, $"{ensaioID}|exclui", TipoEnvio.Imagem)))
            {
                ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
            }
            else ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.ERRO_INESPERADO);
        }

        public async Task AlteraImagem(int imgAtual, string novaImg, string ensaioID)
        {
            await ExcluiImagem(imgAtual, ensaioID, false);
            await AdicionaImagem(novaImg, ensaioID);
        }
    }

    public class Portifolio
    {
        [JsonProperty("nomeImagem")]
        public string NomeImagem { get; set; }
        [JsonProperty("imagem")]
        public string Imagem { get; set; }
    }

}
