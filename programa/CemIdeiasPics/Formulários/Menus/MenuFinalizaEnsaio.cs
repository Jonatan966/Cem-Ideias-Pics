using CemIdeiasPics.Classes.Online;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuFinalizaEnsaio : CemIdeiasPics.Utils.Modelos.FrmModeloDialogo
    {
        public string EnsaioID { get; set; } = string.Empty;
        private class Contabilidade
        {
            [JsonProperty("TPEVALOR")]
            public float ValorPorFoto { get; set; }
            [JsonProperty("ADRVALOR")]
            public float ValorExtra { get; set; }
        }
        public MenuFinalizaEnsaio()
        {
            InitializeComponent();
        }

        private async void MenuFinalizaEnsaio_Load(object sender, EventArgs e)
        {
            Contabilidade contabilidade = JsonConvert.DeserializeObject<Contabilidade[]>(
                await ConectaServidor.EnviarItem(
                    $"SELECT TPEVALOR, ADRVALOR " +
                    $"FROM ENSAIOS " +
                    $"INNER JOIN ADERECOS ON ADRID = ENSADERECO " +
                    $"INNER JOIN TIPO_ENSAIO ON ENSTIPO = TPEID " +
                    $"WHERE ENSID = {EnsaioID}")
            )[0];
        }

    }
}
