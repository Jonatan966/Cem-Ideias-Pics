using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CemIdeiasPics.Utils.Classes.ViaCEP;
using CemIdeiasPics.Utils.Classes;

namespace CemIdeiasPics.Utils.Modelos
{
    public partial class MdlEndereco : UserControl
    {
        public MdlEndereco()
        {
            InitializeComponent();
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
                CEP cep = await ViaCEP.BuscarCEP(txbCEP.Text);
                if (int.Parse(cep.Resultado) > 0)
                {
                    txbBairro.Text = cep.Bairro;
                    txbCidade.Text = cep.Cidade;
                    txbUF.Text = cep.Uf;
                    txbLogradouro.Text = $"{cep.TipoLogradouro} {cep.Logradouro}";
                }
                btnBuscar.Enabled = txbCEP.Enabled = true;
            }
        }
    
    }
}
