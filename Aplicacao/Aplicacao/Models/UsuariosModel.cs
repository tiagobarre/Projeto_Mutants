using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace Aplicacao.Models
{
    public class UsuariosModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }        
        public string phone { get; set; }        
        public string website { get; set; }        
        public Address address { get; set; }
        public Company company { get; set; }
        public string ExibirJSON { get; set; }
        public string DesabilitarTabela { get; set; }
        public string descricao { get; set; }
        public string data { get; set; }
        public string DesabilitarTabelaLog { get; set; }



        public List<UsuariosModel> ListarTodosUsuarios(string metodo)
        {
            List<UsuariosModel> retorno = new List<UsuariosModel>();
            List<UsuariosModel> retorno2 = new List<UsuariosModel>();
            UsuariosModel item2;
            DAL.DAL objListar = new DAL.DAL();

            DesabilitarTabela = "none";
            DesabilitarTabelaLog = "none";

            if (metodo == "carregar")
            {
                Log("Carregou a consulta em tabelas na web.");

                string json = Servico.RequestGET("users", string.Empty).ToString();
                retorno = JsonConvert.DeserializeObject<List<UsuariosModel>>(json);

                DesabilitarTabela = "";
                DesabilitarTabelaLog = "none";

                return retorno;
            }           

            if (metodo == "visualizarJSON")
            {
                string json = Servico.RequestGET("users", string.Empty).ToString();
                retorno = JsonConvert.DeserializeObject<List<UsuariosModel>>(json);

                Log("Carregou a lista JSON na web.");

                ExibirJSON = json.ToString();
                DesabilitarTabela = "none";
                DesabilitarTabelaLog = "none";
                return retorno;
            }

            if (metodo == "logs")
            {
                string sql = "select * from projeto_mutant.log order by data desc";

                DataTable dt = objListar.RetDataTable(sql);

                for (int i = 0; i < dt.Rows.Count ; i++)
                {
                    item2 = new UsuariosModel();

                    item2.descricao =  dt.Rows[i]["descricao"].ToString();
                    item2.data =  dt.Rows[i]["data"].ToString();

                    retorno2.Add(item2);
                }

                Log("Carregou a consulta de logs em tabelas na web.");
                DesabilitarTabela = "none";
                DesabilitarTabelaLog = "";

                return retorno2;
            }

            if (metodo == "salvar")
            {
                string json = Servico.RequestGET("users", string.Empty).ToString();
                retorno = JsonConvert.DeserializeObject<List<UsuariosModel>>(json);

                if(retorno != null)
                {
                    foreach (var item in (List<UsuariosModel>)retorno)
                    {
                        id = item.id;
                        name = item.name.ToString();
                        username = item.username.ToString();
                        email = item.email.ToString();
                        email = item.email.ToString();
                        string street = item.address.street.ToString();
                        string suite = item.address.suite.ToString();
                        string city = item.address.city.ToString();
                        string zipcode = item.address.zipcode.ToString();
                        string lat = item.address.geo.lat.ToString();
                        string lng = item.address.geo.lng.ToString();
                        phone = item.phone.ToString();
                        website = item.website.ToString();
                        string name_company = item.company.name.ToString();
                        string catchPhrase = item.company.catchPhrase.ToString();
                        string bs = item.company.bs.ToString();

                        DAL.DAL objDAL1 = new DAL.DAL();
                        DAL.DAL objDAL2 = new DAL.DAL();
                        DAL.DAL objDAL3 = new DAL.DAL();
                        DAL.DAL objDAL4 = new DAL.DAL();

                        string sqlAddress = $"insert into projeto_mutant.address (id_usuarios, street, suite, city, zipcode) values ('{id}','{street}','{suite}','{city}','{zipcode}')";
                        string sqlCompany = $"insert into projeto_mutant.company (id_usuarios, name, catchPhrase, bs) values ('{id}','{name}','{catchPhrase}','{bs}')";
                        string sqlGeo = $"insert into projeto_mutant.geo (id_usuarios, lat, lng) values ('{id}','{lat}','{lng}')";
                        string sqlUsuarios = $"insert into projeto_mutant.usuarios(id, name, username, email, phone, website) values ('{id}','{name}','{username}','{email}','{phone}','{website}')";

                        objDAL1.ExecutarComandoSQL(sqlAddress);
                        objDAL2.ExecutarComandoSQL(sqlCompany);
                        objDAL3.ExecutarComandoSQL(sqlGeo);
                        objDAL4.ExecutarComandoSQL(sqlUsuarios);

                       
                        DesabilitarTabelaLog = "none";
                    }

                    Log("Dados de usuários salvos com sucesso!");
                }
            }

            return retorno;

        }

        public List<UsuariosModel> SalvarUsuarios()
        {
            List<UsuariosModel> retorno = new List<UsuariosModel>();

            id = id;
            name = name.ToString();
            username = username.ToString();
            email = email.ToString();
            email = email.ToString();
            string street = address.street.ToString();
            string suite = address.suite.ToString();
            string city = address.city.ToString();
            string zipcode = address.zipcode.ToString();
            string lat = address.geo.lat.ToString();
            string lng = address.geo.lng.ToString();
            phone = phone.ToString();
            website = website.ToString();
            string name_company = company.name.ToString();
            string catchPhrase = company.catchPhrase.ToString();
            string bs = company.bs.ToString();

            DAL.DAL objDAL1 = new DAL.DAL();
            DAL.DAL objDAL2 = new DAL.DAL();
            DAL.DAL objDAL3 = new DAL.DAL();
            DAL.DAL objDAL4 = new DAL.DAL();

            string sqlAddress = $"insert into projeto_mutant.address (id_usuarios, street, suite, city, zipcode) values ('{id}','{street}','{suite}','{city}','{zipcode}')";
            string sqlCompany = $"insert into projeto_mutant.company (id_usuarios, name, catchPhrase, bs) values ('{id}','{name}','{catchPhrase}','{bs}')";
            string sqlGeo = $"insert into projeto_mutant.geo (id_usuarios, lat, lng) values ('{id}','{lat}','{lng}')";
            string sqlUsuarios = $"insert into projeto_mutant.usuarios(id, name, username, email, phone, website) values ('{id}','{name}','{username}','{email}','{phone}','{website}')";

            objDAL1.ExecutarComandoSQL(sqlAddress);
            objDAL2.ExecutarComandoSQL(sqlCompany);
            objDAL3.ExecutarComandoSQL(sqlGeo);
            objDAL4.ExecutarComandoSQL(sqlUsuarios);

            Log("Dados de usuários salvos com sucesso!");

            return retorno;
        }


        public List<UsuariosModel> Log(string Log_evento)
        {
            List<UsuariosModel> retorno = new List<UsuariosModel>();

            DAL.DAL objDAL5 = new DAL.DAL();

            string sql = $"insert into projeto_mutant.log (descricao, data) values('{Log_evento}','{DateTime.Now}')";
            
            objDAL5.ExecutarComandoSQL(sql);

            return retorno;
        }

      



    }
}
