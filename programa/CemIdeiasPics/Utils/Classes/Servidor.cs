﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;

namespace CemIdeiasPics.Utils.Classes
{
    class Servidor
    {
        public static string urlAddress = "http://cemideias-pics.000webhostapp.com/src/php/ConexaoMySQL.php";
        private protected static string pwd = "7fe182bcddb67905fbd39db957e23116";

        public static string EnviarComandoSQL(string comando)
        {
            string pagesource = string.Empty;
            try
            {
               using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                            { "acesso", pwd },  //order: {"parameter name", "parameter value"}
                            { "cmd", comando }
                    };
                    pagesource = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    return pagesource;
                }
            }
            catch
            {
                return pagesource;
            }
        }
    }
}
