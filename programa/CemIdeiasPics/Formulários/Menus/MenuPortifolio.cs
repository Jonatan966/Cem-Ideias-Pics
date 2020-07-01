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
using CemIdeiasPics.Classes.Manipuladores;
using CemIdeiasPics.Classes.Online;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuPortifolio : UserControl
    {
        Servidor.PortifolioLoader PortifolioLoader = new Servidor.PortifolioLoader();
        int position = 0;

        public MenuPortifolio()
        {
            InitializeComponent();
        }

        async Task LoadImg(bool all = false)
        {
            btnAnterior.Enabled = btnProximo.Enabled = false;
            if (all)
            {
                position = 0;
                await PortifolioLoader.CarregaImagens(cbxEnsaios.SelectedValue.ToString());
            }
            pbxImagem.Image = PortifolioLoader.CarregaImagem(position);
            lblContagem.Text = PortifolioLoader.portifolio.Length == 0 ? "Sem imagens" : $"{position + 1} de {PortifolioLoader.portifolio.Length} imagens";
            btnAnterior.Enabled = btnProximo.Enabled = true;
        }

        private async void MenuPortifolio_Load(object sender, EventArgs e)
        {
            Ensaio[] ensaios = JsonConvert.DeserializeObject<Ensaio[]>(await ConectaServidor.EnviarItem("SELECT ENSID, CONCAT(ENSID, ' - ', DATE(ENSDATA)) ENSCLIENTE FROM ENSAIOS"));
            cbxEnsaios.DataSource = ManipulaTabela.ConverteClassesEmTabela(ensaios, true, "ID", "DESC");
        }

        private async void cbxEnsaios_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadImg(true);
        }

        private async void btnControle_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(((Button)sender).Tag);
            if ((position + pos) >= 0 && (position + pos) < PortifolioLoader.portifolio.Length)
            {
                position += pos;
                await LoadImg();
            }
        }
    }
}
