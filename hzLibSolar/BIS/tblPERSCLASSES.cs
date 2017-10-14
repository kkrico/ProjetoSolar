using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HzLibConnection.Data;

namespace hzLibSolar.BIS
{
    /// <summary>
    /// Classe que gerencia os dados da tabela tblPERSCLASSES
    /// </summary>
    public class PERSCLASSES
    {
        public string PERSCLASSID;
        /// <summary>
        /// Chave primaria da tabela
        /// </summary>
        public string PERSCLASSTYPE;
        /// <summary>
        /// 
        /// </summary>
        public string DISPLAYTEXTCUSTOMER;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static DataTable GET(HzConexao connection)
        {
            try
            {
                string sql = "SELECT [PERSCLASSID] ,[PERSCLASSTYPE] ,[DISPLAYTEXTCUSTOMER],DISPLAYTEXT, ISDISABLED,DATEDELETED FROM [acedb].[bsuser].[PERSCLASSES] where persclasstype = 'V'  order by DISPLAYTEXTCUSTOMER";
                return connection.loadDataTable(sql);
            }
            catch (Exception ex)
            {
                
                throw new Exception ("Erro ao buscar o tipo de pessoas!");
            }
        }
    }
}
