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
using CemIdeiasPics.Classes.Manipuladores;

namespace CemIdeiasPics.Utils.Modelos
{
    public partial class MdlEndereco : UserControl
    {
        public string NumCEP = string.Empty;
        public CEP ResultCEP;
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
        }

        public void PesquisaCEP(string cep)
        {
            txbCEP.Text = cep;
            btnBuscar.PerformClick();
        }

        void MostraCEP()
        {
            txbBairro.Text = ResultCEP.Bairro;
            txbCidade.Text = ResultCEP.Cidade;
            txbUF.Text = ResultCEP.Uf;
            txbLogradouro.Text = $"{ResultCEP.TipoLogradouro} {ResultCEP.Logradouro}";
        }

        private void BloqueiaNumeros_Event(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13)
            {
                e.Handled = char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar);
            }
            else btnBuscar.PerformClick();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string cmdSelect = $"SELECT 1 resultado, ENDESTADO uf, ENDCIDADE cidade, ENDBAIRRO bairro, ENDLOGRADOURO logradouro FROM ENDERECOS WHERE ENDCEP = {txbCEP.Text}";
            CEP[] results = JsonConvert.DeserializeObject<CEP[]>(await ConectaServidor.EnviarItem(cmdSelect));

            btnBuscar.Enabled = false;
            if (results.Length == 0)
            {
                ResultCEP = await BuscarCEP(txbCEP.Text);
                if (ResultCEP.Resultado != "0")
                {
                    await ConectaServidor.EnviarItem(ResultCEP.RetornaComandoSQL(txbCEP.Text));
                    NumCEP = txbCEP.Text;
                }
                else
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.RESULTADO_NAO_ENCONTRADO);
            }
            else
            {
                ResultCEP = results[0];
                NumCEP = txbCEP.Text;
            }
            MostraCEP();
            btnBuscar.Enabled = true;
        }
    }
}
