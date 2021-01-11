using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Models
{
    public class Log
    {
        public string descricao { get; set; }
        public string data { get; set; }

        public List<Log> BuscarLogs()
        {
            List<Log> retorno2 = new List<Log>();
            Log item2;
            DAL.DAL objListar = new DAL.DAL();

            string sql = "select * from projeto_mutant.log order by data desc";

            DataTable dt = objListar.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item2 = new Log();

                item2.descricao = dt.Rows[i]["descricao"].ToString();
                item2.data = dt.Rows[i]["data"].ToString();

                retorno2.Add(item2);
            }

            return retorno2;
        }
    }
}
