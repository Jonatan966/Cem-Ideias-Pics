using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CemIdeiasPics.Classes.Manipuladores;
using CemIdeiasPics.Classes.Online;
using CemIdeiasPics.Classes.Consultas;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuEnsaios : UserControl
    {
        Ensaio[] ensaios;
        public MenuEnsaios()
        {
            InitializeComponent();
        }
        async Task<bool> AtualizaLista()
        {
            ensaios = JsonConvert.DeserializeObject<Ensaio[]>(
            await ConectaServidor.EnviarItem("SELECT * FROM VW_ENSAIOS"));
            dgvEnsaios.DataSource = ManipulaTabela.ConverteClassesEmTabela(ensaios,false,
                "ID", "Cliente", "Usuario", "CEP", "Num", "Data", "Preco", "Tipo", "Album", "Pagamento");
            ManipulaTabela.OcultarColunas(ref dgvEnsaios,"ID","Usuario","CEP","Num","Tipo","Album","Pagamento");
            return true;
        }
        void LimpaTudo()
        {
            cbxClientes.SelectedIndex = 0;
            cbxTipoAlbum.SelectedIndex = 0;
            cbxTipoEnsaio.SelectedIndex = 0;
            cbxMetodoPagamento.SelectedIndex = 0;

            mdlEndereco1.LimpaTudo();
            dtpDataEnsaio.Value = DateTime.Now.Date;
            dtpHoraEnsaio.Value = DateTime.Now;
            btnRegistrar.Text = "Registrar";
            btnLimpar.Text = "Limpar";
            btnFinalizarEnsaio.Text = "Finalizar Ensaio";
            btnFinalizarEnsaio.Tag = false;
            cbxClientes.Enabled = true;
        }
        void FiltraCliente(string filtro)
        {
            ((DataTable)dgvEnsaios.DataSource).DefaultView.RowFilter = $"{cbxFiltro.SelectedItem} LIKE '%{filtro}%'";
        }

        private async void MenuEnsaios_Load(object sender, EventArgs e)
        {
            await AtualizaLista();
            dgvEnsaios.ClearSelection();
            Cliente[] clientes = JsonConvert.DeserializeObject<Cliente[]>(await ConectaServidor.EnviarItem("SELECT CLICPF, CONCAT(CLINOME,' - ', CLICPF) CLINOME FROM CLIENTES GROUP BY CLICPF"));

            cbxClientes.DataSource = ManipulaTabela.ConverteClassesEmTabela(clientes,true, "CPF", "NOME");
            cbxTipoEnsaio.DataSource = ManipulaTabela.ConverteClassesEmTabela((JsonConvert.DeserializeObject<TipoItens[]>(await ConectaServidor.EnviarItem("SELECT TPID, CONCAT(TPNOME, ' - R$', TPVALOR) AS TPNOME FROM TIPOS WHERE TPTIPO = 2"))),true, "ID", "TIPO");
            cbxTipoAlbum.DataSource = ManipulaTabela.ConverteClassesEmTabela((JsonConvert.DeserializeObject<TipoItens[]>(await ConectaServidor.EnviarItem("SELECT TPID, CONCAT(TPNOME, ' - R$', TPVALOR) AS TPNOME FROM TIPOS WHERE TPTIPO = 1"))), true, "ID", "TIPO");
            cbxMetodoPagamento.DataSource = ManipulaTabela.ConverteClassesEmTabela((JsonConvert.DeserializeObject<TipoItens[]>(await ConectaServidor.EnviarItem("SELECT TPID, TPNOME FROM TIPOS WHERE TPTIPO = 3"))), true, "ID", "TIPO");

            foreach (DataGridViewColumn coluna in dgvEnsaios.Columns)
            {
                cbxFiltro.Items.Add(coluna.HeaderText);
            }
        }

        private async void btnRecarregar_Click(object sender, EventArgs e)
        {
            await AtualizaLista();
            dgvEnsaios.ClearSelection();
            LimpaTudo();

        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            dgvEnsaios.ClearSelection();
            LimpaTudo();
        }

        private async void btnLimpar_Click(object sender, EventArgs e)
        {
            if (btnLimpar.Text == "Excluir")
            {
                if (ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CONFIRMA_ACAO, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (bool.Parse(await ConectaServidor.EnviarItem($"DELETE FROM ENSAIOS WHERE ENSID = {dgvEnsaios.SelectedRows[0].Cells[0].Value}")))
                    {
                        await ConectaPortifolio.ExcluiPortifolio(dgvEnsaios.SelectedRows[0].Cells[0].Value.ToString());
                    }
                }
            }
            btnRecarregar.PerformClick();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbxClientes.SelectedIndex >= 0 && cbxTipoAlbum.SelectedIndex >= 0 && cbxTipoEnsaio.SelectedIndex >= 0)
            {
                if (mdlEndereco1.ResultCEP != null ? int.Parse(mdlEndereco1.ResultCEP.Resultado) > 0 : string.IsNullOrWhiteSpace(mdlEndereco1.NumCEP))
                {
                    string cmd = $"INSERT INTO ENSAIOS(ENSCLIENTE, ENSUSUARIO, ENSTIPO, ENSCEP, ENSNUMLOCAL, ENSDATA, ENSALBUM, ENSPAGAMENTO) VALUES('{cbxClientes.SelectedValue}', {Program.Usuario.USUID}, {cbxTipoEnsaio.SelectedValue}, {mdlEndereco1.NumCEP}, {txbNumeroRes.Text}, '{dtpDataEnsaio.Value:yy-MM-dd} {dtpHoraEnsaio.Value:hh:mm:ss}', {cbxTipoEnsaio.SelectedValue}, {cbxMetodoPagamento.SelectedValue})";
                    if (btnRegistrar.Text != "Registrar")
                    {
                        cmd = $"UPDATE ENSAIOS SET ENSCLIENTE = '{cbxClientes.SelectedValue}',ENSUSUARIO = {Program.Usuario.USUID},ENSTIPO = {cbxTipoEnsaio.SelectedValue},ENSCEP = {mdlEndereco1.NumCEP},ENSNUMLOCAL = {txbNumeroRes.Text},ENSDATA = '{dtpDataEnsaio.Value:yy-MM-dd} {dtpHoraEnsaio.Value:hh:mm:ss}', ENSALBUM = {cbxTipoAlbum.SelectedValue}, ENSTIPO = {cbxTipoEnsaio.SelectedValue}, ENSPAGAMENTO = {cbxMetodoPagamento.SelectedValue} WHERE ENSID = {dgvEnsaios.SelectedRows[0].Cells[0].Value}";
                    }

                    bool confirm = bool.Parse(await ConectaServidor.EnviarItem(cmd));
                    if (confirm)
                    {
                        ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                        btnRecarregar.PerformClick();
                    }
                }
            }
            else ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.PREENCHIMENTO_INCOMPLETO);
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            FiltraCliente(txbPesquisa.Text);
        }

        private void dgvEnsaios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEnsaios.SelectedRows.Count > 0)
            {
                int selected = dgvEnsaios.SelectedRows[0].Index;

                cbxClientes.SelectedValue = ensaios[selected].Enscliente;
                cbxTipoEnsaio.SelectedItem = ensaios[selected].Enstipo;
                cbxTipoAlbum.SelectedValue = ensaios[selected].EnsAdereco;
                cbxMetodoPagamento.SelectedValue = ensaios[selected].Pagamento;
                dtpDataEnsaio.Value = DateTime.Parse(ensaios[selected].Ensdata).Date;
                dtpHoraEnsaio.Value = DateTime.Parse(ensaios[selected].Ensdata);
                txbNumeroRes.Text = ensaios[selected].Ensnumlocal;

                btnFinalizarEnsaio.Text = float.TryParse(dgvEnsaios.SelectedRows[0].Cells[6].Value.ToString(), out _) ? "Visualizar Valores" : "Finalizar Ensaio";
                btnFinalizarEnsaio.Tag = float.TryParse(dgvEnsaios.SelectedRows[0].Cells[6].Value.ToString(), out _);

                btnRegistrar.Text = "Salvar";
                btnLimpar.Text = "Excluir";
                cbxClientes.Enabled = false;

                mdlEndereco1.PesquisaCEP(ensaios[selected].Enscep);
            }
        }

        private void btnPortifolio_Click(object sender, EventArgs e)
        {
            if (btnLimpar.Text == "Limpar")
            {
                ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.EXIGE_CADASTRO);
                return;
            }
            _ = new MenuCadPortifolio 
                { EnsaioID = dgvEnsaios.SelectedRows[0].Cells[0].Value.ToString() }.ShowDialog();
        }

        private void btnFinalizarEnsaio_Click(object sender, EventArgs e)
        {
            if (new MenuFinalizaEnsaio() { EnsaioID = dgvEnsaios.SelectedRows[0].Cells[0].Value.ToString(), View = (bool)btnFinalizarEnsaio.Tag }.ShowDialog() == DialogResult.Yes)
                btnRecarregar.PerformClick();
        }

        private void dgvEnsaios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (float.TryParse(dgvEnsaios.Rows[e.RowIndex].Cells[6].Value.ToString(), out _))
                dgvEnsaios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            else
                dgvEnsaios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
        }
    }
}
