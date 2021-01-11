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

                try
                {
                    obj.ListarTodosUsuarios("carregar");
                    obj.Log("Sucesso: ListarTodosUsuarios est� funcionando corretamente");
                }
                catch (Exception ex)
                {

                    obj.Log($"Erro: {ex}");
                }
                

                
            }

           
        }

        [TestMethod]
        public void Vizualizar_JSON()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();

                try
                {
                    obj.ListarTodosUsuarios("visualizarJSON");
                    obj.Log("Sucesso: Vizualizar_JSON est� funcionando corretamente");
                }
                catch (Exception ex)
                {

                    obj.Log($"Erro: {ex}");
                }
              


            }


        }
        [TestMethod]
        public void Vizualizar_Logs()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();

                try
                {
                    obj.ListarTodosUsuarios("logs");
                    obj.Log("Sucesso: Vizualizar_Logs est� funcionando corretamente");
                }
                catch (Exception ex)
                {

                    obj.Log($"Erro: {ex}");
                }
                


            }


        }
        [TestMethod]
        public void Salvar_DB()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();

                try
                {
                    obj.ListarTodosUsuarios("salvar");
                    obj.Log("Sucesso: Salvar_DB est� funcionando corretamente");
                }
                catch (Exception ex)
                {

                    obj.Log($"Erro: {ex}");
                }

               


            }


        }
        [TestMethod]
        public void Salvar_Usuarios()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();

                try
                {
                    obj.ListarTodosUsuarios("salvar");
                    obj.Log("Sucesso: Salvar_Usuarios est� funcionando corretamente");
                }
                catch (Exception ex)
                {

                    obj.Log($"Erro: {ex}");
                }
                


            }


        }
        [TestMethod]
        public void Salvar_Logs()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UsuariosModel obj = new UsuariosModel();

                try
                {
                    obj.ListarTodosUsuarios("salvar");
                    obj.Log("Sucesso: Salvar_Logs est� funcionando corretamente");
                }
                catch (Exception ex)
                {

                    obj.Log($"Erro: {ex}");
                }
               


            }


        }
    }
}
