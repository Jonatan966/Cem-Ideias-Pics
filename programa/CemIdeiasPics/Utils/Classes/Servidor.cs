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
using CemIdeiasPics.Classes.Online;

namespace CemIdeiasPics.Utils.Classes
{
        public class PortifolioLoader
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
}
