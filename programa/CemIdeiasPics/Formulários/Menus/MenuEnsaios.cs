﻿using System;
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
            await ConectaServidor.EnviarItem("SELECT ENSID, ENSCLIENTE, ENSUSUARIO, TPETIPO AS 'ENSTIPO', ENSCEP, ENSNUMLOCAL, ENSDATA, ENSPRECO, ENSDIRETORIO, ENSADERECO FROM ENSAIOS INNER JOIN TIPO_ENSAIO ON TPEID = ENSTIPO"));
            dgvEnsaios.DataSource = ManipulaTabela.ConverteClassesEmTabela(ensaios,false,
                "ID", "Cliente", "Usuario", "Tipo", "CEP", "Num", "Data", "Preco", "Diretorio", "Adereco");
            ManipulaTabela.OcultarColunas(ref dgvEnsaios,"ID","Usuario","CEP","Num", "Diretorio","Adereco");
            return true;
        }
        void LimpaTudo()
        {
            cbxClientes.SelectedIndex = 0;
            cbxTipoAlbum.SelectedIndex = 0;
            cbxTipoEnsaio.SelectedIndex = 0;
            mdlEndereco1.LimpaTudo();
            dtpDataEnsaio.Value = DateTime.Now.Date;
            btnRegistrar.Text = "Registrar";
            btnLimpar.Text = "Limpar";
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
            cbxTipoEnsaio.DataSource = ManipulaTabela.ConverteClassesEmTabela((JsonConvert.DeserializeObject<TipoItens[]>(await ConectaServidor.EnviarItem("SELECT TPEID AS TPID, CONCAT(TPETIPO, ' - R$', TPEVALOR) AS TPNOME FROM TIPO_ENSAIO"))),false, "ID", "TIPO");
            cbxTipoAlbum.DataSource = ManipulaTabela.ConverteClassesEmTabela((JsonConvert.DeserializeObject<TipoItens[]>(await ConectaServidor.EnviarItem("SELECT ADRID AS TPID, CONCAT(ADRNOME, ' - R$', ADRVALOR) AS TPNOME FROM ADERECOS"))), false, "ID", "TIPO");

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
                    string cmd = $"INSERT INTO ENSAIOS(ENSCLIENTE, ENSUSUARIO, ENSTIPO, ENSCEP, ENSNUMLOCAL, ENSDATA, ENSADERECO) VALUES('{cbxClientes.SelectedValue}', {Program.Usuario.USUID}, {cbxTipoEnsaio.SelectedValue}, {mdlEndereco1.NumCEP}, {txbNumeroRes.Text}, '{dtpDataEnsaio.Value:yy-MM-dd}', {cbxTipoEnsaio.SelectedValue})";
                    if (btnRegistrar.Text != "Registrar")
                    {
                        cmd = $"UPDATE ENSAIOS SET ENSCLIENTE = '{cbxClientes.SelectedValue}',ENSUSUARIO = {Program.Usuario.USUID},ENSTIPO = {cbxTipoEnsaio.SelectedValue},ENSCEP = {mdlEndereco1.NumCEP},ENSNUMLOCAL = {txbNumeroRes.Text},ENSDATA = '{dtpDataEnsaio.Value:yy-MM-dd}', ENSADERECO = {cbxTipoAlbum.SelectedValue}, ENSTIPO = {cbxTipoEnsaio.SelectedValue} WHERE ENSID = {dgvEnsaios.SelectedRows[0].Cells[0].Value}";
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

        private async void dgvEnsaios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEnsaios.SelectedRows.Count > 0)
            {
                int selected = dgvEnsaios.SelectedRows[0].Index;

                cbxClientes.SelectedValue = ensaios[selected].Enscliente;
                cbxTipoEnsaio.SelectedItem = ensaios[selected].Enstipo;
                cbxTipoAlbum.SelectedValue = ensaios[selected].EnsAdereco;
                dtpDataEnsaio.Value = DateTime.Parse(ensaios[selected].Ensdata);
                txbNumeroRes.Text = ensaios[selected].Ensnumlocal;

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
            new MenuCadPortifolio 
                { EnsaioID = dgvEnsaios.SelectedRows[0].Cells[0].Value.ToString() }.ShowDialog();
        }
    }
}
