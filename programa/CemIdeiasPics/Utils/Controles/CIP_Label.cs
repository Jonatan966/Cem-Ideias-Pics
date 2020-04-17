using System;
using System.Drawing;
using System.Windows.Forms;

namespace CemIdeiasPics.Utils.Controles
{
    class CIP_Label : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.AutoSize = false;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Font = new System.Drawing.Font(new System.Drawing.FontFamily(System.Drawing.Text.GenericFontFamilies.SansSerif), 12);
        }
    }
}
