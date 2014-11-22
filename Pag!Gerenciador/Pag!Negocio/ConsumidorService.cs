using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pag_Negocio
{
    public class ConsumidorService
    {
        public Mensagens.Consumidor GerarConsumidor(Mensagens.Consumidor p_consumidor)
        {
            try
            {
                //var pesq = new Mensagens.Estabelecimento();
                //pesq.estabelecimentoId = "1213";

                //var queryJson = "{consumidorId: '999', consumidorTipo: 1, estabelecimentoId: '1213', estabelecimentoNome: 'Empresa 1', qrCode : '12139991a'}";
                //var queryJson = "{estabelecimentoId: '1213', consumidorTipo: 1, consumidorId: '1'}";

                //var jsonObjectPesq = JsonConvert.SerializeObject(queryJson);

                if (string.IsNullOrEmpty(p_consumidor.consumidorId))
                    throw new Exception("Id do consumidor inválido.");
                if (p_consumidor.consumidorTipo <= 0)
                    throw new Exception("Tipo do consumidor inválido.");


                var wc = new WebClient();
                var uri = wc.DownloadString(Util.UrlBaseApi);
                var jsonObject = JsonConvert.SerializeObject(p_consumidor);
                wc.Headers.Add("Content-Type", "application/json");
                var webapi = wc.UploadString(Util.UrlBaseApi + "api/consumidor", "POST", jsonObject); //Salva consumidor                

                //Verificar se consumidor já existe
                //var pesquisa = wc.UploadString(Util.UrlBaseApi + "api/consumidor/search", "POST", jsonObjectPesq);
                

                //Se já existe, retorna os dados

                //Se não existe, grava o consumidor e retorna os dados
                //wc.UploadString(Util.UrlBaseApi + "api/consumidor", "POST", jsonObject);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return p_consumidor;
        }

    }
}
