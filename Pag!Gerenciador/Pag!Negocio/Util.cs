using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag_Negocio
{
    public static class Util
    {
        public const string UrlBaseApi = "http://pagws.herokuapp.com/";
        public const string linkPag = "http://www.pagaai.com.br/";

        public static string IdEstabelecimento()
        {
            return ConfigurationManager.AppSettings["IdEstabelecimento"].ToString();
        }
    }
}
