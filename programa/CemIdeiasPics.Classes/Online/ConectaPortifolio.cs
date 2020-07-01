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

        public async Task ExcluiImagem(int img, string ensaioID, bool carregaImgs = true)
        {
            if (portifolio.Length > 0)
            {
                if (bool.Parse(await ConectaServidor.EnviarItem(portifolio[img].NomeImagem, $"{ensaioID}|exclui", TipoEnvio.Imagem)))
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

        public static async Task ExcluiPortifolio(string ensaioID)
        {
            if (bool.Parse(await EnviarItem(string.Empty, $"{ensaioID}|exclui", TipoEnvio.Imagem)))
            {
                Mensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
            }
            else Mensagens.MostrarMensagem(MensagensPredefinidas.ERRO_INESPERADO);
        }

        public async Task AlteraImagem(int imgAtual, string novaImg, string ensaioID)
        {
            await ExcluiImagem(imgAtual, ensaioID, false);
            await AdicionaImagem(novaImg, ensaioID);
        }
    }
}
