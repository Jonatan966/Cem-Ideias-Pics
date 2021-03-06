﻿using CemIdeiasPics.Classes.Manipuladores;
using CemIdeiasPics.Classes.Online;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemIdeiasPics.Formulários.Menus
{
    public partial class MenuCadPortifolio : Utils.Modelos.FrmModeloDialogo
    {
        public string EnsaioID;
        private int position = 0;
        private ConectaPortifolio PortifolioLoader = new ConectaPortifolio();
        public MenuCadPortifolio()
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
            lblContagem.Text = $"{position + 1} de {PortifolioLoader.portifolio.Length}";
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

        private async void MenuCadPortifolio_Load(object sender, EventArgs e)
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
            if ((position + pos) >= 0 && (position + pos) < PortifolioLoader.portifolio.Length)
            {
                position += pos;
                await LoadImg();
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.CONFIRMA_ACAO, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (objExportaImagens.ShowDialog() == DialogResult.OK)
            {
                List<Image> final = new List<Image>();
                for(int x = 0; x < PortifolioLoader.portifolio.Length; x++)
                {
                    final.Add(PortifolioLoader.CarregaImagem(x));
                }
                if (ManipulaImagem.ConverteImagensParaZip(objExportaImagens.FileName, final.ToArray()))
                    ManipulaMensagens.MostrarMensagem(MensagensPredefinidas.OPERACAO_CONCLUIDA);
            }
        }
    }
}
