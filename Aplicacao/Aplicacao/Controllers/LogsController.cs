using Aplicacao.Models;
using Microsoft.AspNetCore.Mvc;
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
    public class LogsController : ControllerBase
    {
        UsuariosModel _log = new UsuariosModel();

        // GET: api/<LogsController>
        [HttpGet]
        public List<Log> GET()
        {
            _log.Log("Realizando consulta logs metodo GET");
            return new Log().BuscarLogs();
        }


    }
}
