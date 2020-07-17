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
    public partial class ConfigGerenciaUsuarios : CemIdeiasPics.Utils.Modelos.FrmModeloDialogo
    {
        public ConfigGerenciaUsuarios() { InitializeComponent(); }
        private async void btnLimparTudo_Click(object sender, EventArgs e) { await LimpaTudo(); }
        private void VerificaMudanca(object sender, EventArgs e) { btnSalvar.Text = "Salvar"; }
        private async void ConfigGerenciaUsuarios_Load(object sender, EventArgs e) { await LimpaTudo(); }

        async Task<bool> LimpaTudo()
        {
            string res = await ConectaServidor.EnviarItem("SELECT '-1' USUID, '(Novo Usuário)' USUNOME FROM USUARIOS UNION SELECT USUID, CONCAT(USUID, ' - ',USUNOME) FROM USUARIOS");
            Usuario[] usuarios = JsonConvert.DeserializeObject<Usuario[]>(res);
            cbxUsuarios.DataSource = ManipulaTabela.ConverteClassesEmTabela(usuarios, true, "id", "user");

            txbConfSenha.Clear();
            txbCPF.Clear();
            txbEmail.Clear();
            txbLogin.Clear();
            txbNome.Clear();
            txbSenha.Clear();
            txbTelefone.Clear();

            cbxTipoAcesso.SelectedIndex = 0;
            rbnFeminino.Checked = rbnMasculino.Checked = false;
            return true;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
            {
                string sql;
                if (ConsultaTexto.ValidaCPF(txbCPF.Text))
                {
                    if (txbSenha.Text == txbConfSenha.Text)
                    {
                        if (cbxUsuarios.SelectedIndex == 0)
                        {
                            sql = "INSERT INTO USUARIOS(USUCPF,USUNOME,USUSEXO,USUTELEFONE,USULOGIN,USUSENHA,USUTIPO,USUEMAIL) " +
                                $"VALUES('{txbCPF.Text}','{txbNome.Text}',{1 + Convert.ToUInt16(rbnFeminino.Checked)},'{txbTelefone.Text}','{txbLogin.Text}',md5('{txbSenha.Text}'),{cbxTipoAcesso.SelectedIndex + 1},'{txbEmail.Text}')";
                        }
                        else
                        {
                            sql = $"UPDATE USUARIOS SET USUCPF = '{txbCPF.Text}', USUNOME = '{txbNome.Text}', USUSEXO = {1 + Convert.ToUInt16(rbnFeminino.Checked)}, USUTELEFONE = '{txbTelefone.Text}', USULOGIN = '{txbLogin.Text}', {(!string.IsNullOrWhiteSpace(txbSenha.Text) ? $"USUSENHA = md5('{txbSenha.Text}'), " : "")} USUTIPO = {1 + cbxTipoAcesso.SelectedIndex}, USUEMAIL = '{txbEmail.Text}' WHERE USUID = {cbxUsuarios.SelectedValue}";
                        }
                        if (bool.Parse(await ConectaServidor.EnviarItem(sql)))
                        {
                            ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
                            await LimpaTudo();
                        }
                        else ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CREDENCIAIS_INCORRETAS);
                    }
                }
                else ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CPF_INVALIDO);
            }
            else this.Close();
        }

        private async void cbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUsuarios.SelectedIndex != 0)
            {
                string res = await ConectaServidor.EnviarItem($"SELECT USUCPF, USUNOME, USUSEXO, USUTELEFONE, USULOGIN, USUBLOQUEIO, USUEMAIL, USUIMG, USUTIPO FROM USUARIOS WHERE USUID = {cbxUsuarios.SelectedValue}");
                Usuario usuario = JsonConvert.DeserializeObject<Usuario[]>(res)[0];
                txbCPF.Text = usuario.USUCPF;
                txbNome.Text = usuario.USUNOME;
                txbTelefone.Text = usuario.USUTELEFONE;
                txbEmail.Text = usuario.USUEMAIL;
                txbLogin.Text = usuario.USULOGIN;
                cbxTipoAcesso.SelectedItem = usuario.USUTIPO;

                rbnFeminino.Checked = !(rbnMasculino.Checked = usuario.USUSEXO == "M");
            }
        }
    }
}
