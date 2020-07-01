using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CemIdeiasPics.Classes.Manipuladores
{
    public static class ManipulaTabela
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

        public static DataTable ConverteClassesEmTabela(object[] classes, bool deleteNull, params string[] colunas)
        {
            List<Array> arrays = new List<Array>();
            foreach (object classe in classes)
            {
                arrays.Add(ManipulaArray.ConverteClasseEmArray(classe, deleteNull));
            }
            return PreencherTabela(arrays.ToArray(), colunas);
        }
    }
}
