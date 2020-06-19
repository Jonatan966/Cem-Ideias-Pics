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
        OPERACAO_CONCLUIDA = 4,
        CONFIRMA_ACAO = 5,
        PREENCHIMENTO_INCOMPLETO = 6,
        EXIGE_CADASTRO = 7,
        CREDENCIAIS_INCORRETAS = 8,
        ERRO_INESPERADO = 9
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
            "1§CPF inválido.",
            "1§Nome inválido.",
            "1§Email inválido.",
            "3§Operação concluída com sucesso!",
            "2§Deseja mesmo executar essa ação? Ela não poderá ser desfeita.",
            "0§Preencha todos os campos corretamente",
            "1§Você só pode executar esta ação com itens já cadastrados.",
            "1§Login incorreto",
            "1§Ocorreu um erro inesperado."
        };

        public static DialogResult MostrarMensagem(MensagensPredefinidas mensagem, MessageBoxButtons tipo = MessageBoxButtons.OK)
        {
            string[] msg = Predefinidos[(int)mensagem].Split('§');
            int type = int.Parse(msg[0]);
            return MessageBox.Show(msg[1], Tipos[type], tipo, Icones[type]);
        }
    }
}
