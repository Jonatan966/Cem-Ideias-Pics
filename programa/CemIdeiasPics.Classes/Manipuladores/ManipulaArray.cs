﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Manipuladores
{
    public static class ManipulaArray
    {
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

        public static Array ConverteClasseEmArray(object classe, bool deleteNull = false)
        {
            IEnumerable<string> res = classe.GetType().GetProperties().Select(p => {
                object value = p.GetValue(classe, null);
                return value == null ? null : value.ToString();
            });
            if (deleteNull)
            {
                res = res.Where(c => c != null);
            }
            return res.ToArray();
        }
        public static Array[] ConverteClassesEmArray(object[] classes)
        {
            Array[] resultado = new Array[classes.Length];
            for (int i = 0; i < classes.Length; i++)
            {
                resultado[i] = ConverteClasseEmArray(classes[i]);
            }
            return resultado;
        }

    }
}
