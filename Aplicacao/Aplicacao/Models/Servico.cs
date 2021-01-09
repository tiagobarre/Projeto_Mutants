using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Aplicacao.Models
{
    public class Servico
    {
        public static string URI = "https://jsonplaceholder.typicode.com/";

        private static string RequesteGET_DELETE(string metodo, string parametro, string tipo)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo + "/" + parametro);
           // request.Headers.Add("Token", TOKEN);
            request.Method = tipo;
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch (Exception)
            {

                return("Nenhum registro encontrado ao consumir a API da Mutant's!");
            }
            
        }

        public static string RequestGET(string metodo, string parametro)
        {
            return RequesteGET_DELETE(metodo, parametro, "GET");
        }


    }
}
