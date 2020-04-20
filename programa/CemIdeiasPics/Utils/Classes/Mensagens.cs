using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemIdeiasPics.Utils.Classes
{
    public static class Mensagens
    {
        private static string[] Tipos { get; } = 
        { 
            "Aviso!", 
            "Erro!", 
            "Confirmação" 
        };
        private static MessageBoxIcon[] Icones { get; } = 
        { 
            MessageBoxIcon.Warning, 
            MessageBoxIcon.Error, 
            MessageBoxIcon.Asterisk 
        };
        public enum MensagensPredefinidas 
        {
            RESULTADO_NAO_ENCONTRADO = 0
        }
        private static string[] Predefinidos { get; } =
        {
            "1§O resultado da busca não foi encontrado."
        };

        public static DialogResult MostrarMensagem(MensagensPredefinidas mensagem)
        {
            string[] msg = Predefinidos[(int)mensagem].Split('§');
            int type = int.Parse(msg[0]);
            return MessageBox.Show(msg[1], Tipos[type], MessageBoxButtons.OK, Icones[type]);
        }
    }
}
