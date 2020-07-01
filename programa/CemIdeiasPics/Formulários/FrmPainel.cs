using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CemIdeiasPics.Classes.Manipuladores;
using CemIdeiasPics.Formulários.Menus;
using CemIdeiasPics.Utils.Classes;

namespace CemIdeiasPics.Formulários
{
    public partial class FrmPainel : CemIdeiasPics.Utils.Modelos.FrmModeloDialogo
    {
        public FrmPainel()
        {
            if (new FrmLogin().ShowDialog() == DialogResult.Yes)
            {
                InitializeComponent();
                this.SetBevel(false);
            }
        }

        private void FrmPainel_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.Usuario.USUNOME;
            pictureBox1.Region = ManipulaImagem.ImagemRedonda(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.ImageLocation = Program.Usuario.USUIMG;
            rbnPortifolio.PerformClick();
        }

        #region Painel Lateral
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void RbnMenus_Click(object sender, EventArgs e)
        {
            pnlMenus.Controls.Clear();
            switch (Convert.ToUInt16(((Control)sender).Tag))
            {
                case 0:
                    pnlMenus.Controls.Add(new MenuPortifolio() { Dock = DockStyle.Fill });
                    break;
                case 1:
                    pnlMenus.Controls.Add(new MenuClientes() { Dock = DockStyle.Fill });
                    break;
                case 2:
                    pnlMenus.Controls.Add(new MenuEnsaios() { Dock = DockStyle.Fill });
                    break;
                case 3:
                    pnlMenus.Controls.Add(new MenuConfigs() { Dock = DockStyle.Fill });
                    break;
            }
        }
        #endregion
    }
}
