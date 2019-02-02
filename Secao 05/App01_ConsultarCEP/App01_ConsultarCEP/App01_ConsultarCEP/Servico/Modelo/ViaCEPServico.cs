using System;
using System.Collections.Generic;
using System.Text;
using System.Net; //Biblioteca de referencia de internet
using App01_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json; //Newtonsoft.Json instalação dessaa biblioteca

namespace App01_ConsultarCEP.Servico.Modelo
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;

            return end;
        }

        //este metodo é o cep que o usuário vai digitar na tela




    }
}
 