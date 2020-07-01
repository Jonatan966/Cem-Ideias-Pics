using CemIdeiasPics.Utils.Classes;
using CemIdeiasPics.Utils.Consultas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CemIdeiasPics.Classes.Online;
using CemIdeiasPics.Classes.Manipuladores;

namespace CemIdeiasPics.Formulários
{
    public partial class FrmLogin : CemIdeiasPics.FrmModeloBase
    {
        public FrmLogin()
        {
            InitializeComponent();
            tbcPassos.Appearance = TabAppearance.FlatButtons;
            tbcPassos.ItemSize = new Size(0, 1);
            tbcPassos.SizeMode = TabSizeMode.Fixed;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        async Task<bool> Carregamento()
        {
            int etapas = -1;
            tbcPassos.SelectedIndex = 0;
            while (true)
            {
                etapas++;
                await Task.Delay(3000);
                switch (etapas)
                {
                    case 0:
                        string validador = await ConectaServidor.EnviarItem("SELECT 'true'");
                        if (validador == "false"){
                            lblErro.Text = "Não foi possível conectar ao servidor";
                            tbcPassos.SelectedIndex = 2;
                            break;
                        }
                        continue;
                    case 1:
                        tbcPassos.SelectedIndex = 1;
                        break;
                }
                break;
            }
            return true;
        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            await Carregamento();
        }

        private async void btnReiniciar_Click(object sender, EventArgs e)
        {
            await Carregamento();
        }

        private async void btnFazerLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbUsuario.Text) && !string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                tlpInferior.Enabled = false;
                string resultado = await ConectaServidor.EnviarItem($"SELECT USUID, USUNOME, USUIMG FROM USUARIOS WHERE USULOGIN = '{txbUsuario.Text}' AND USUSENHA = MD5('{txbSenha.Text}')");
                if (!string.IsNullOrWhiteSpace(resultado))
                {
                    if (resultado != "false")
                    {
                        Program.Usuario = JsonConvert.DeserializeObject<Usuario[]>(resultado)[0];
                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CREDENCIAIS_INCORRETAS);
                    }
                }
                else
                {
                    lblErro.Text = "Não foi possível conectar ao servidor";
                    tbcPassos.SelectedIndex = 2;
                }
                tlpInferior.Enabled = true;
            }
            else
            {
                ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.PREENCHIMENTO_INCOMPLETO);
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
