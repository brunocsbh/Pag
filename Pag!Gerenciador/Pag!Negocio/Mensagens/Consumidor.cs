
namespace Pag_Negocio.Mensagens
{
    public class Consumidor
    {
        public string estabelecimentoId
        {
            get
            {
                return Util.IdEstabelecimento();
            }
        }
        public string estabelecimentoNome
        {
            get
            {
                return "Empresa 1";
            }
        }
        public int consumidorTipo { get; set; }
        public string consumidorId { get; set; }
        public string qrCode
        {
            get
            {
                return Util.linkPag + "?id=" + estabelecimentoId + "-" + consumidorTipo + "-" + consumidorId.ToString();
            }
        }
    }
}
