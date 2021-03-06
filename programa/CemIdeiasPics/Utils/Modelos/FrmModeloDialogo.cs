﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CemIdeiasPics.Utils.Modelos
{
    public enum TipoDialogo { Simples, Completo }
    public partial class FrmModeloDialogo : CemIdeiasPics.FrmModeloBase
    {
        public TipoDialogo TipoDoDialogo { get; set; } = TipoDialogo.Completo;
        public FrmModeloDialogo()
        {
            InitializeComponent();
        }

        #region Mover Formulário
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.Size == this.MinimumSize)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.Size == this.MinimumSize)
                this.Size = this.MaximumSize = Screen.GetWorkingArea(this).Size;
            else
                this.Size = this.MinimumSize;
            this.CenterToScreen();
        }

        private void FrmModeloDialogo_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            switch (TipoDoDialogo)
            {
                case TipoDialogo.Simples:
                    btnMaximizar.Enabled = btnMinimizar.Enabled = false;
                    break;
            }
            this.MinimumSize = this.Size;
        }

        private void FrmModeloDialogo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
        }
    }
}
