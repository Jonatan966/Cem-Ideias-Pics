using CemIdeiasPics.Classes.Consultas;
using CemIdeiasPics.Classes.Manipuladores;
using CemIdeiasPics.Classes.Online;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuFinalizaEnsaio : CemIdeiasPics.Utils.Modelos.FrmModeloDialogo
    {
        public string EnsaioID { get; set; } = string.Empty;
        private float Subtotal { get; set; } = 0;
        public bool View { get; set; } = false;
        private class Contabilidade
        {
            [JsonProperty("valor")]
            public float ValorPorFoto { get; set; }
            public float ValorExtra { get; set; }
        }
        public MenuFinalizaEnsaio()
        {
            InitializeComponent();
        }

        private async void MenuFinalizaEnsaio_Load(object sender, EventArgs e)
        {
            btnFinalizar.Text = View ? "OK" : "Finalizar Ensaio";

            Contabilidade contabilidade = new Contabilidade();
            contabilidade.ValorPorFoto = JsonConvert.DeserializeObject<Contabilidade[]>(await ConectaServidor.EnviarItem($"SELECT TPVALOR valor FROM TIPOS WHERE TPID IN (SELECT ENSTIPO FROM ENSAIOS WHERE ENSID = {EnsaioID})"))[0].ValorPorFoto;
            contabilidade.ValorExtra = JsonConvert.DeserializeObject<Contabilidade[]>(await ConectaServidor.EnviarItem($"SELECT TPVALOR valor FROM TIPOS WHERE TPID IN (SELECT ENSALBUM FROM ENSAIOS WHERE ENSID = {EnsaioID})"))[0].ValorPorFoto;
            
            txbContFotos.Text = await ConectaServidor.EnviarItem(string.Empty, $"{EnsaioID}|conta", TipoEnvio.Imagem);
            txbValorFoto.Text = $"R${contabilidade.ValorPorFoto}";
            txbExtras.Text = $"R${contabilidade.ValorExtra}";
            txbSubtotal.Text = $"R${Subtotal = contabilidade.ValorPorFoto*int.Parse(txbContFotos.Text)+contabilidade.ValorExtra}";

        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (btnFinalizar.Text != "OK")
            {
                if (ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CONFIRMA_ACAO, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (bool.Parse(await ConectaServidor.EnviarItem($"UPDATE ENSAIOS SET ENSPRECO = {Subtotal.ToString().Replace(',', '.')} WHERE ENSID = {EnsaioID}")))
                    {
                        ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                        DialogResult = DialogResult.Yes;
                    }
                    else
                        ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.ERRO_INESPERADO);

                }
            }
            else this.Close();
        }
    }
}
