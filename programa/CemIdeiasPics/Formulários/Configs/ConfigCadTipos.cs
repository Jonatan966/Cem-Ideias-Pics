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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemIdeiasPics.Formulários.Configs
{
    public partial class ConfigCadTipos : CemIdeiasPics.Utils.Modelos.FrmModeloDialogo
    {
        public ConfigCadTipos()
        {
            InitializeComponent();
        }
        private TipoItens[] Tipos;
        public enum TipoCadastro { Album, Ensaio }
        public TipoCadastro Tipo { get; set; }

        async Task<bool> LimpaTudo(bool reset = true)
        {
            if (reset)
            {
                string json = await ConectaServidor.EnviarItem("SELECT -1 TPID, '(Novo Tipo)' TPNOME, 0.00 TPVALOR UNION SELECT TPID, TPNOME, TPVALOR FROM TIPOS WHERE TPTIPO = " + (((int)Tipo)+1));
                Tipos = JsonConvert.DeserializeObject<TipoItens[]>(json);
                cbxTipos.DataSource = ManipulaTabela.ConverteClassesEmTabela(Tipos, false, "id", "tipo", "valor");
            }
            txbNomeTipo.Clear();
            txbValorTipo.Clear();
            return true;
        }

        private async void cbxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipos.SelectedIndex > 0)
            {
                btnLimparTudo.Text = "Excluir";
                txbNomeTipo.Text = Tipos[cbxTipos.SelectedIndex].Tipo;
                txbValorTipo.Text = Tipos[cbxTipos.SelectedIndex].Valor;
            }
            else 
            {
                btnLimparTudo.Text = "Limpar Tudo";
                await LimpaTudo(false); 
            }
        }

        private async void ConfigCadTipos_Load(object sender, EventArgs e)
        {
            Text = "Tipos de " + Tipo;
            await LimpaTudo();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
            {
                string consulta;
                if (cbxTipos.SelectedIndex == 0)
                    consulta = $"INSERT INTO TIPOS (TPNOME, TPVALOR, TPTIPO) VALUES('{txbNomeTipo.Text}', {txbValorTipo.Text}, {((int)Tipo) + 1})";
                else
                    consulta = $"UPDATE TIPOS SET TPNOME = '{txbNomeTipo.Text}', TPVALOR = {txbValorTipo.Text} WHERE TPID = {cbxTipos.SelectedValue}";
                if (bool.Parse(await ConectaServidor.EnviarItem(consulta)))
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                await LimpaTudo();
            }
            else this.Close();
        }

        private void VerificaMudanca(object sender, EventArgs e)
        {
            btnSalvar.Text = "Salvar";
        }

        private async void btnLimparTudo_Click(object sender, EventArgs e)
        {
            switch (btnLimparTudo.Text)
            {
                case "Limpar Tudo":
                    await LimpaTudo(false);
                    break;
                case "Excluir":
                    if (ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CONFIRMA_ACAO, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        if (bool.Parse(await ConectaServidor.EnviarItem("DELETE FROM TIPOS WHERE TPID = " + cbxTipos.SelectedValue)))
                        {
                            ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                            await LimpaTudo();
                        }
                    break;
            }
        }
    }
}
