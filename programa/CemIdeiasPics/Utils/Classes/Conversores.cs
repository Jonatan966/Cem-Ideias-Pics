using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemIdeiasPics.Utils.Classes
{
    class Manipuladores
    {

        /// <summary>
        /// É responsável por preencher um <see cref="DataGridView"/> o conteúdo de um array
        /// </summary>
        /// <param name="linhas">É inserido o array com os conteúdos a serem inseridos</param>
        /// <param name="colunas">É inserído os nomes das colunas</param>
        /// <returns>Retorna um <see cref="DataTable"/> que poderá ser usado para preencher um <see cref="DataGridView"/></returns>
        public static DataTable PreencherTabela(Array linhas, string[] colunas)
        {
            DataTable oTabela = new DataTable();

            for (int cols = 0; cols < colunas.Length; cols++)
            {
                oTabela.Columns.Add(colunas[cols]);
            }
            for (int x = 0; x < linhas.Length; x++)
            {
                Array lista;
                if (((lista = ((object[])linhas.GetValue(x)).Cast<string>().ToArray()).Length) == colunas.Length)
                {
                    oTabela.Rows.Add((string[])lista);
                }
                else
                {
                    oTabela.Rows.Add();
                }
            }
            return oTabela;
        }

        /// <summary>
        /// Este método é responsável por converter o conteúdo de um array de strings com separadores para um <see cref="Array"/>
        /// </summary>
        /// <param name="linhas">É inserido o array de strings</param>
        /// <param name="corte">É inserido o separador para o corte</param>
        /// <returns></returns>
        public static Array ImportarLinhasParaArray(string[] linhas, char corte)
        {
            ArrayList lista = new ArrayList();
            for (int x = 0; x < linhas.Length; x++)
            {
                lista.Add(linhas[x].Split(corte));
            }
            return lista.ToArray();
        }

        public static Array ValidaArray(ArrayList lista)
        {
            ArrayList final = new ArrayList();
            for (int x = 0; x < lista.Count; x++)
            {
                if (((object[])lista[x]).Length != 0)
                {
                    bool validador = true;
                    for (int y = 0; y < ((object[])lista[x]).Length; y++)
                    {
                        if (!string.IsNullOrEmpty(((object[])lista[x])[y].ToString()))
                        {
                            continue;
                        }
                        else
                        {
                            validador = false;
                        }
                    }
                    if (validador)
                    {
                        final.Add(lista[x]);
                    }
                }
            }
            return final.ToArray();
        }

        public static ArrayList ConverteArrayEmList(Array array)
        {
            ArrayList lis = new ArrayList();
            for (int x = 0; x < array.Length; x++)
            {
                lis.Add(array.GetValue(x));
            }
            return lis;
        }
    }
}
