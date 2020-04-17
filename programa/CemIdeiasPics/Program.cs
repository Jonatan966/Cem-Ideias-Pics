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
        public static string Usuario { get; set; }
        public static string ImgPerfil { get; set; }
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
