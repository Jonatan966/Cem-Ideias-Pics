using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Consultas
{
    public class ConsultaTexto
    {
        public static bool ValidaCPF(string CPF)
        {
            int[] digitos = { 0, 0 };
            if (CPF.Length == 14 && CPF[3] == '.' && CPF[7] == '.' && CPF[11] == '-')
            {
                string[] corte = CPF.Replace(".", string.Empty).Split('-');
                if (int.TryParse(corte[1], out _) && int.TryParse(corte[0], out _))
                {
                    for (int y = 0; y < 2; y++)
                    {
                        int somatoria = 0;
                        for (int x = 0; x < corte[0].Length; x++)
                        {
                            somatoria += ((10 + y) - x) * int.Parse(corte[0][x].ToString());
                        }
                        digitos[0 + y] = (11 - (somatoria % 11)) > 9 ? 0 : (11 - (somatoria % 11));
                        if (y == 0) corte[0] += digitos[0];
                    }

                    return (int.Parse(corte[1][0].ToString()) == digitos[0] && int.Parse(corte[1][1].ToString()) == digitos[1]);
                }
            }
            return false;
        }

        public static bool ValidaNome(string nome)
        {
            string regexPatern = "^(da|do|dos|das|de)|([A-Z][a-z][a-z][a-z])";
            if (!string.IsNullOrWhiteSpace(nome))
            {
                string[] nomeCompleto = nome.Split(' ');
                if (nomeCompleto.Length >= 2)
                    return nomeCompleto.All(c => c.Length >= 2 && Regex.IsMatch(c, regexPatern));
            }
            return false;
        }

        public static bool ValidaEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                string[] emailCompleto = email.Split('@');
                if (emailCompleto.Length == 2)
                {
                    return (emailCompleto[1].Split('.').All(c => !string.IsNullOrWhiteSpace(c)));
                }
            }
            return false;
        }
    }
}
