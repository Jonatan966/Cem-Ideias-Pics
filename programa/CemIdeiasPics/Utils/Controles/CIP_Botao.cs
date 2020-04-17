using System;
using System.Drawing;
using System.Windows.Forms;
namespace CemIdeiasPics.Controles
{
    public class CIP_Botao : Button
    {
        public Color Fundo { get; set; } = Color.Yellow;
        protected override void InitLayout()
        {
            base.InitLayout();
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.Black;
            this.Font = SystemFonts.CaptionFont;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Fundo;
        }

    }
}
