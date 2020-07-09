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
using CemIdeiasPics.Classes.Online;
using static CemIdeiasPics.Classes.Online.ConectaCEP;

namespace CemIdeiasPics.Utils.Modelos
{
    public partial class MdlEndereco : UserControl
    {
        public CEP ResultCEP;
        public string NumCEP = string.Empty;
        public MdlEndereco()
        {
            InitializeComponent();
        }
        
        public void LimpaTudo()
        {
            txbBairro.Clear();
            txbCidade.Clear();
            txbUF.Clear();
            txbLogradouro.Clear();
            txbCEP.Clear();
            ResultCEP = null;
            NumCEP = string.Empty;
        }

        private void BloqueiaNumeros_Event(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txbCEP.Text.Length == txbCEP.MaxLength)
            {
                btnBuscar.Enabled = txbCEP.Enabled = false;
                ResultCEP = await ConectaCEP.BuscarCEP(txbCEP.Text);
                if (int.Parse(ResultCEP.Resultado) > 0)
                {
                    PreencheCEP();
                }
                btnBuscar.Enabled = txbCEP.Enabled = true;
            }
        }
    
    }
}
