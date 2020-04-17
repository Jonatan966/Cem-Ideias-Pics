using CemIdeiasPics.Utils.Classes;
using CemIdeiasPics.Utils.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            int etapas = -1;
            while (true)
            {
                etapas++;
                await Task.Delay(3000);
                switch (etapas)
                {
                    case 0:
                        string validador = await Task.Run(() => Servidor.EnviarComandoSQL(""));
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
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private async void btnFazerLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbUsuario.Text) && !string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                tlpInferior.Enabled = false;
                string resultado = await Task.Run(() => Servidor.EnviarComandoSQL($"SELECT USUNOME, USUIMG FROM USUARIOS WHERE USULOGIN = '{txbUsuario.Text}' AND USUSENHA = MD5('{txbSenha.Text}')"));
                if (!string.IsNullOrWhiteSpace(resultado) && resultado != "false")
                {
                    Program.Usuario = resultado.Split('|')[0];
                    Program.ImgPerfil = resultado.Split('|')[1];
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    Misc.DialogosPersonalizados(Misc.Dialogos.LoginIncorreto);
                }
                tlpInferior.Enabled = true;
            }
            else
            {
                Misc.DialogosPersonalizados(Misc.Dialogos.FaltandoInformação);
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
