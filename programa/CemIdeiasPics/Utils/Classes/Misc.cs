using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemIdeiasPics.Utils.Classes
{
    public static class Misc
    {
        public enum Dialogos { FaltandoInformação, LoginIncorreto}

        public static void DialogosPersonalizados(Dialogos dialg)
        {
            switch (dialg)
            {
                case Dialogos.FaltandoInformação:
                    MessageBox.Show("Preencha os campos corretamente e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Dialogos.LoginIncorreto:
                    MessageBox.Show("Usuário e/ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static Region ImagemRedonda(int w, int h)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(5, 5, w - 15, h - 5);
            return new Region(gp);
        }

        public static void OcultarColunas(ref DataGridView tabela, params string[] colunas)
        {
            foreach (string item in colunas)
            {
                tabela.Columns[item].Visible = false;
            }
        }
    }
}
