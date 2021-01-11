using Aplicacao.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AplicacaoTests
{
    [TestClass]
    public class UsuariosModelTeste
    {
      
        [TestMethod]
        public void APi_Consulta_Json()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();

               
                obj.ListarTodosUsuarios("carregar");

                
            }

           
        }

        [TestMethod]
        public void Vizualizar_JSON()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();


                obj.ListarTodosUsuarios("visualizarJSON");


            }


        }
        [TestMethod]
        public void Vizualizar_Logs()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();


                obj.ListarTodosUsuarios("logs");


            }


        }
        [TestMethod]
        public void Salvar_DB()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();


                obj.ListarTodosUsuarios("salvar");


            }


        }
        [TestMethod]
        public void Salvar_Usuarios()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();


                obj.ListarTodosUsuarios("salvar");


            }


        }
        [TestMethod]
        public void Salvar_Logs()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();


                obj.ListarTodosUsuarios("salvar");


            }


        }
    }
}
