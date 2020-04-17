using System;
using System.Drawing;
using System.Windows.Forms;

namespace CemIdeiasPics.Utils.Controles
{
    public class CIP_CaixaDeTexto : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            this.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 12);
            //this.BorderStyle = BorderStyle.None;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.Font = new Font(new FontFamily("Microsoft Sans Serif"), 10);
            this.Margin = new Padding(10);

        }





    }
}
