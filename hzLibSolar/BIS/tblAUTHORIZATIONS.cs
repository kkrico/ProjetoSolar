using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HzLibConnection.Data;

namespace hzLibSolar
{
    /// <summary>
    /// 
    /// </summary>
    public class tblAUTHORIZATIONS
    {
        #region Variaveis
        public string AUTHID;
        /// <summary>
        /// Chave primaria da tabela
        /// </summary>
        public string SHORTNAME;
        /// <summary>
        /// Descrição do campo local na GridView
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns> 
	#endregion

        #region Funções
        public static DataTable GET(HzConexao connection)
        {
            try
            {
                string sql = "SELECT  [AUTHID] ,[SHORTNAME], [NAME] FROM [acedb].[bsuser].[AUTHORIZATIONS] order by SHORTNAME";
                return connection.loadDataTable(sql);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao buscar as autorizações!");
            }
        }
        
        #endregion
    }
}
