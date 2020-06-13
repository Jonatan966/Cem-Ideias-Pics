using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemIdeiasPics.Utils.Classes
{
    public enum MensagensPredefinidas
    {
        RESULTADO_NAO_ENCONTRADO = 0,
        CPF_INVALIDO = 1,
        NOME_INVALIDO = 2,
        EMAIL_INVALIDO = 3,
        OPERACAO_CONCLUIDA = 4
    }

    public static class Mensagens
    {
        private static string[] Tipos { get; } = 
        { 
            "Aviso!", 
            "Erro!", 
            "Confirmação",
            "Êxito!"
        };
        private static MessageBoxIcon[] Icones { get; } = 
        { 
            MessageBoxIcon.Warning, 
            MessageBoxIcon.Error, 
            MessageBoxIcon.Asterisk,
            MessageBoxIcon.Exclamation
        };
        private static string[] Predefinidos { get; } =
        {
            "1§O resultado da busca não foi encontrado.",
            "2§CPF inválido.",
            "2§Nome inválido.",
            "2§Email inválido.",
            "4§Operação concluída com sucesso!"
        };

        public static DialogResult MostrarMensagem(MensagensPredefinidas mensagem)
        {
            string[] msg = Predefinidos[(int)mensagem].Split('§');
            int type = int.Parse(msg[0]);
            return MessageBox.Show(msg[1], Tipos[type], MessageBoxButtons.OK, Icones[type]);
        }
    }
}
