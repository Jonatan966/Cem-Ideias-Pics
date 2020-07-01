using CemIdeiasPics.Utils.Classes;
using CemIdeiasPics.Utils.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CemIdeiasPics.Classes.Online;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuCadastroPortifolio : Form
    {
        public string EnsaioID;
        private int position = 0;
        private ConectaPortifolio PortifolioLoader = new ConectaPortifolio();
        public MenuCadastroPortifolio()
        {
            InitializeComponent();
        }

        async Task LoadImg(bool all = false)
        {
            if (all) 
            {
                position = 0;
                await PortifolioLoader.CarregaImagens(EnsaioID); 
            }
            pbxImagem.Image = PortifolioLoader.CarregaImagem(position);
            lblContagem.Text = $"{position+1} de {PortifolioLoader.portifolio.Length}";
            btnExcluir.Enabled = btnAlterar.Enabled = !(PortifolioLoader.portifolio.Length == 0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Enabled = false;
                pbrProgresso.Style = ProgressBarStyle.Marquee;

                await PortifolioLoader.AdicionaImagem(openFileDialog1.FileName, EnsaioID);
                await LoadImg(true);

                panel1.Enabled = true;
                pbrProgresso.Style = ProgressBarStyle.Blocks;
            }
        }

        private async void MenuCadastroPortifolio_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            pbrProgresso.Style = ProgressBarStyle.Marquee;

            await LoadImg(true);

            panel1.Enabled = true;
            pbrProgresso.Style = ProgressBarStyle.Blocks;
        }

        private async void btnControle_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(((Button)sender).Tag);
            if ((position+pos) >= 0 && (position+pos) < PortifolioLoader.portifolio.Length)
            {
                position += pos;
                await LoadImg();
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagens.MostrarMensagem(MensagensPredefinidas.CONFIRMA_ACAO, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                panel1.Enabled = false;
                pbrProgresso.Style = ProgressBarStyle.Marquee;

                await PortifolioLoader.ExcluiImagem(position, EnsaioID);
                await LoadImg(true);

                panel1.Enabled = true;
                pbrProgresso.Style = ProgressBarStyle.Blocks;
            }
        }

        private async void btnAlterar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Enabled = false;
                pbrProgresso.Style = ProgressBarStyle.Marquee;

                await PortifolioLoader.AlteraImagem(position, openFileDialog1.FileName, EnsaioID);
                await LoadImg(true);

                panel1.Enabled = true;
                pbrProgresso.Style = ProgressBarStyle.Blocks;
            }
        }
    }
}
