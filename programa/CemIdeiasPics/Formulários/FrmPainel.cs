using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            lblUsuario.Text = Program.Usuario;
            pictureBox1.Region = Misc.ImagemRedonda(pictureBox1.Width, pictureBox1.Height);
        }

        #region Painel Lateral
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        #endregion

    }
}
