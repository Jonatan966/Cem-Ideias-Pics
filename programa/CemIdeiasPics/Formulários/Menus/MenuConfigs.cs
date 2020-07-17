using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CemIdeiasPics.Formulários.Configs;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuConfigs : UserControl
    {
        public MenuConfigs()
        {
            InitializeComponent();
        }

        private void btnGerenciarUsuarios_Click(object sender, EventArgs e)
        {
            _ = new ConfigGerenciaUsuarios().ShowDialog();
        }
    }
}
