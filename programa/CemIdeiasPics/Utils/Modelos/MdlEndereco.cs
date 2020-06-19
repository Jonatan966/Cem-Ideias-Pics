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
using Newtonsoft.Json;

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
        
        public async Task<string> ConverteCEP()
        {
            if (ResultCEP == null)
            {
                await CarregaCEP();
            }
            return $"INSERT INTO ENDERECOS VALUES({NumCEP}, '{ResultCEP.Uf}', '{ResultCEP.Cidade}', '{ResultCEP.Bairro}', '{ResultCEP.TipoLogradouro??""} {ResultCEP.Logradouro}')";
        }
        void PreencheCEP()
        {
            txbBairro.Text = ResultCEP.Bairro;
            txbCidade.Text = ResultCEP.Cidade;
            txbUF.Text = ResultCEP.Uf;
            txbLogradouro.Text = $"{ResultCEP.TipoLogradouro} {ResultCEP.Logradouro}";
            NumCEP = txbCEP.Text;
        }
        async Task<bool> CarregaCEP()
        {
            string cepJson = await Servidor.EnviarItem($"SELECT ENDCEP resultado_txt, ENDESTADO uf, ENDCIDADE cidade, ENDBAIRRO bairro, ENDLOGRADOURO logradouro FROM ENDERECOS WHERE ENDCEP = {txbCEP.Text}");
            ResultCEP = JsonConvert.DeserializeObject<CEP[]>(cepJson)[0];
            NumCEP = txbCEP.Text;
            ResultCEP.Resultado = "1";
            return true;
        }
        public async Task<bool> CarregaCEP(string cep)
        {
            LimpaTudo();
            for (int i = 0; i < txbCEP.MaxLength-cep.Length; i++)
            {
                txbCEP.Text += "0";
            }
            txbCEP.Text += cep;
            await CarregaCEP();
            PreencheCEP();
            return true;
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
                ResultCEP = await BuscarCEP(txbCEP.Text);
                if (int.Parse(ResultCEP.Resultado) > 0)
                {
                    PreencheCEP();
                }
                btnBuscar.Enabled = txbCEP.Enabled = true;
            }
        }
    
    }
}
