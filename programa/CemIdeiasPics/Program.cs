using CemIdeiasPics.Classes.Consultas;
using CemIdeiasPics.Formulários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemIdeiasPics
{
    static class Program
    {
        public static Usuario Usuario { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPainel());
            //Teste
        }
    }
}
