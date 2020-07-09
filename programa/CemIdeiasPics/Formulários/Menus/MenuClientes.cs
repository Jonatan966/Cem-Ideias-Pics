using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CemIdeiasPics.Utils.Classes;
using Newtonsoft.Json;
using CemIdeiasPics.Classes.Manipuladores;
using CemIdeiasPics.Classes.Online;
using CemIdeiasPics.Classes.Consultas;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuClientes : UserControl
    {
        Cliente[] clientes;

        public MenuClientes()
        {
            InitializeComponent();
        }

        async Task<bool> AtualizaLista()
        {
            clientes = JsonConvert.DeserializeObject<Cliente[]>(
            await ConectaServidor.EnviarItem("SELECT * FROM CLIENTES"));
            dgvClientes.DataSource = ManipulaTabela.ConverteClassesEmTabela(clientes,false, 
                "CPF", "Nome", "Sexo","Nasc", "Telefone", "Email","Num","CEP","Complemento");
            ManipulaTabela.OcultarColunas(ref dgvClientes, "Nasc", "Num", "CEP", "Complemento");
            return true;
        }
        void FiltraCliente(string filtro)
        {
            ((DataTable)dgvClientes.DataSource).DefaultView.RowFilter = $"{cbxFiltro.SelectedItem} LIKE '%{filtro}%'";
        }
        void LimpaTudo()
        {
            txbCPF.Clear();
            txbNome.Clear();
            dtpNascimento.Value = DateTime.Now.Date;
            txbTelefone.Clear();
            txbEmail.Clear();
            txbNumResidencia.Clear();
            cbxComplemento.SelectedIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnLimpar.Text = "Limpar";
            txbCPF.Enabled = true;
            mdlEndereco1.LimpaTudo();
        }

        private async void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (btnLimpar.Text == "Excluir")
            {
                if (ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CONFIRMA_ACAO, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (bool.Parse(await ConectaServidor.EnviarItem($"DELETE FROM CLIENTES WHERE CLICPF = '{txbCPF.Text}'")))
                    {
                        ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                    }
                }
            }
            btnRecarregar.PerformClick();
        }

        private async void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbCPF.Text) && !string.IsNullOrWhiteSpace(txbNome.Text) && !string.IsNullOrWhiteSpace(txbTelefone.Text) && !string.IsNullOrWhiteSpace(txbEmail.Text) && !string.IsNullOrWhiteSpace(txbNumResidencia.Text) && (rbnMasculino.Checked || rbnFeminino.Checked) && cbxComplemento.SelectedIndex >= 0)
            {
                if (!ConsultaTexto.ValidaCPF(txbCPF.Text)) 
                {
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CPF_INVALIDO);
                    return; 
                }
                if (!ConsultaTexto.ValidaNome(txbNome.Text))
                {
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.NOME_INVALIDO);
                    return;
                }
                if (!ConsultaTexto.ValidaEmail(txbEmail.Text))
                {
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.EMAIL_INVALIDO);
                    return;
                }

                if (mdlEndereco1.ResultCEP != null ? int.Parse(mdlEndereco1.ResultCEP.Resultado)>0 : string.IsNullOrWhiteSpace(mdlEndereco1.NumCEP))
                {
                    string cmdInsert = $"INSERT INTO CLIENTES(CLICPF, CLINOME, CLISEXO, CLIDATANASCIMENTO, CLITELEFONE, CLIEMAIL, CLINUMEROCASA, CLICEP, CLICOMPLEMENTO) VALUES('{txbCPF.Text}', '{txbNome.Text}', {(rbnMasculino.Checked ? 1 : 2)}, '{dtpNascimento.Value:yy-MM-dd}', '{txbTelefone.Text}', '{txbEmail.Text}', {txbNumResidencia.Text}, {mdlEndereco1.NumCEP}, {cbxComplemento.SelectedIndex+1})";
                    string cmdEdit = $"UPDATE CLIENTES SET CLINOME = '{txbNome.Text}', CLISEXO = {(rbnMasculino.Checked ? 1 : 2)}, CLIDATANASCIMENTO = '{dtpNascimento.Value:yy-MM-dd}', CLITELEFONE = '{txbTelefone.Text}', CLIEMAIL = '{txbEmail.Text}', CLINUMEROCASA = {txbNumResidencia.Text}, CLICEP = {mdlEndereco1.NumCEP}, CLICOMPLEMENTO = {cbxComplemento.SelectedIndex + 1} WHERE CLICPF = '{txbCPF.Text}'";
                    Clipboard.SetText(cmdEdit);
                    bool confirm = bool.Parse(await ConectaServidor.EnviarItem(btnRegistrar.Text == "Registrar" ? cmdInsert : cmdEdit));
                    if (confirm)
                    {
                        ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                        btnRecarregar.PerformClick();
                    }
                }
            }
            else ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.PREENCHIMENTO_INCOMPLETO);
        }

        private async void MenuClientes_Load(object sender, EventArgs e)
        {
            await AtualizaLista();
            foreach(DataGridViewColumn coluna in dgvClientes.Columns)
            {
                cbxFiltro.Items.Add(coluna.HeaderText);
            }
            cbxFiltro.SelectedIndex = 0;
            dgvClientes.ClearSelection();
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            dgvClientes.ClearSelection();
            LimpaTudo();
        }

        private async void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int selected = dgvClientes.SelectedRows[0].Index;

                txbCPF.Text = clientes[selected].CLICPF;
                txbNome.Text = clientes[selected].CLINOME;
                dtpNascimento.Value = DateTime.Parse(clientes[selected].CLIDATANASCIMENTO);
                txbTelefone.Text = clientes[selected].CLITELEFONE;
                txbEmail.Text = clientes[selected].CLIEMAIL;
                txbNumResidencia.Text = clientes[selected].CLINUMEROCASA;
                rbnMasculino.Checked = clientes[selected].CLISEXO == "M";
                rbnFeminino.Checked = clientes[selected].CLISEXO == "F";
                cbxComplemento.SelectedItem = clientes[selected].CLICOMPLEMENTO;

                mdlEndereco1.PesquisaCEP(clientes[selected].CLICEP);

                btnRegistrar.Text = "Salvar";
                btnLimpar.Text = "Excluir";
                txbCPF.Enabled = false;
            }
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            FiltraCliente(txbPesquisa.Text);
        }

        private async void btnRecarregar_Click(object sender, EventArgs e)
        {
            await AtualizaLista();
            dgvClientes.ClearSelection();
            LimpaTudo();
        }
    }
}
