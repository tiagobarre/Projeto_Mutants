using Aplicacao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index( string metodo)
        {
            UsuariosModel objCliente = new UsuariosModel();
            ViewBag.ListaClientes = objCliente.ListarTodosUsuarios(metodo);
            ViewBag.ExibirJSON = objCliente.ExibirJSON;
            ViewBag.DesabilitarTabela = objCliente.DesabilitarTabela;
            ViewBag.DesabilitarTabelaLog = objCliente.DesabilitarTabelaLog;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
