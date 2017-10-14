using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HzLibConnection.Data;

namespace hzLibSolar.BIS
{
    public class COMPANIES
    {
        #region Funções
        /// <summary>
        /// Consulta da tabela tbl.COMPANIES
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static DataTable GET(HzConexao connection)
        {
            try
            {
                string sql = "SELECT [COMPANYID]  ,[COMPANYNO]   ,[NAME] FROM [acedb].[bsuser].[COMPANIES] order by NAME";
                return connection.loadDataTable(sql);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao buscar as empresas!");
            }
        }
        public static string GETNAME(HzConexao connection, string _COMPANYID)
        {
            try
            {
                string sql = "SELECT [COMPANYID]  ,[COMPANYNO]   ,[NAME] FROM [acedb].[bsuser].[COMPANIES] WHERE COMPANYID='" + _COMPANYID + "' order by NAME";
                DataTable dt= connection.loadDataTable(sql);
                return dt.Rows[0]["COMPANYNO"].ToString().Trim() + " - " + dt.Rows[0]["NAME"].ToString().Trim();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar as empresas!");
            }
        } 
        #endregion
    }
}
