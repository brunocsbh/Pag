using System.Configuration;
namespace Pag_Gerenciador
{
    public static class Util
    {
        public static string IdEstabelecimento()
        {            
            return ConfigurationManager.AppSettings["IdEstabelecimento"].ToString();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
