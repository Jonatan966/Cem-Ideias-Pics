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
        public CEP ResultCEP;
        public string NumCEP = string.Empty;
        public MdlEndereco()
        {
            InitializeComponent();
        }
        
        public string ConverteCEP()
        {
            return $"INSERT INTO ENDERECOS VALUES({NumCEP}, '{ResultCEP.Uf}', '{ResultCEP.Cidade}', '{ResultCEP.Bairro}', '{ResultCEP.TipoLogradouro} {ResultCEP.Logradouro}')";
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
                ResultCEP = await BuscarCEP(txbCEP.Text);
                if (int.Parse(ResultCEP.Resultado) > 0)
                {
                    txbBairro.Text = ResultCEP.Bairro;
                    txbCidade.Text = ResultCEP.Cidade;
                    txbUF.Text = ResultCEP.Uf;
                    txbLogradouro.Text = $"{ResultCEP.TipoLogradouro} {ResultCEP.Logradouro}";
                    NumCEP = txbCEP.Text;
                }
                btnBuscar.Enabled = txbCEP.Enabled = true;
            }
        }
    
    }
}
