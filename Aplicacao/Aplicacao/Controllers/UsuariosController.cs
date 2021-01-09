using Aplicacao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
       UsuariosModel _log = new UsuariosModel();

        // GET: api/<UsuariosController>
        [HttpGet]
        public string Get()
        {
            _log.Log("Realizando consulta pelo metodo GET");
            
            string json = Servico.RequestGET($"users", string.Empty);

            return json;
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public string Get(string id)        
        {
            _log.Log("Realizando consulta por id pelo metodo GET{ID}");

            string json = Servico.RequestGET($"users/{id}", string.Empty);

            return json;
        }


        // POST api/<UsuariosController>
        [HttpPost]
        public ReturnAllServices Post([FromBody] UsuariosModel obj)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                _log.Log("Realizando post pelo metodo POST");

                obj.SalvarUsuarios();
                retorno.Result = true;
                retorno.ErrorMessage = "Dados salvos com sucesso!";

            }
            catch (Exception ex)
            {
                _log.Log($"Erro ao tentar registrar um cliente: {ex.Message}");

                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar registrar um cliente: " + ex.Message;
            }

            return retorno;

        }

     
    }
}
