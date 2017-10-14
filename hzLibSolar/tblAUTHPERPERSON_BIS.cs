using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HzLibConnection.Data;
using HzLibConnection.Sql;

namespace hzLibSolar
{
    public class tblAUTHPERPERSON_BIS
    {
        #region Variaveis

        /// <summary>
        /// Chave primaria da tabela.
        /// </summary>
        public int cmpAUTHPERSON { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tblPERSONS.
        /// </summary>
        public string cmpPERSID { get; set; }
        /// <summary>
        /// Nome do cliente na tabela tblPERSONS.
        /// </summary>
        public string cmpAUTHID { get; set; }
        /// <summary>
        /// Numero da autenticação na tabela tblAUTHPERPERSON.
        /// </summary>
        public DateTime cmpVALIDFROM { get; set; }
        /// <summary>
        /// Data de inicio 
        /// </summary>
        public DateTime cmpVALIDUNTIL { get; set; }
        /// <summary>
        /// Data fim 
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns> 
        #endregion

        #region Funções
        ///<sumary>
        /// Retorna dados da tabela de autenticação
        /// <param name="connection"></param>
        /// <param name="ls"></param>
        /// <returns></returns>
        /// </sumary>
        public static DataTable Get(HzConexao connection)
        {
            try
            {
                string sql = @"SELECT TOP 1000 [cmpAUTHPERSON]
                ,[cmpPERSID]  ,[cmpAUTHID]  ,[cmpVALIDFROM]    ,[cmpVALIDUNTIL] FROM [hzSolar].[dbo].[tblAUTHPERPERSON_BIS]";
                return connection.loadDataTable(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar as autorizações!");
            }
        }
        /// <summary>
        /// Retorna dados para alimentar a GridView.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="ls"></param>
        /// <returns></returns>
        public static DataTable Get(HzConexao connection, ListCampos ls)
        {
            try
            {
                string sql = ListCampo.RetornaSQL("SELECT [cmpAUTHPERSON]  ,[cmpPERSID]  ,[cmpAUTHID]  ,[cmpVALIDFROM]    ,[cmpVALIDUNTIL] FROM [hzSolar].[dbo].[tblAUTHPERPERSON_BIS]", ls);
                return connection.loadDataTable(sql);
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao carregar as autorizações da pessoa!");
            }
        }
        /// <summary>
        /// Grava os dados de consulta da tabela tblPERSONS.
        /// </summary>
        /// <param name="connection"></param>
        public void Save(HzConexao connection)
        {
            try
            {
                string sql = "exec  spIncluirAutorizacao_BIS " + cmpPERSID + ",'" + cmpAUTHID + "','" + cmpVALIDFROM + "','" + cmpVALIDUNTIL + "'";
                connection.executeProcedure(sql);
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao incluir a autorização da pessoa");
            }
        }
        /// <summary>
        /// Exclui os dados gravados da tabela.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="_cmpIDPERSON"></param>
        /// <param name="_cmpAUTHID"></param>
        public static void Excluir(HzConexao connection, string _cmpPERSID)
        {
            try
            {
                string sql = "exec  spExcluirAUTHPERPERSON_BIS " + _cmpPERSID;
                connection.executeProcedure(sql);
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao excluir a autorização!");
            }
        }
        /// <summary>
        /// Dados da autorização 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="_cmpIDPERSON"></param>
        /// <returns></returns>
        public static DataTable GETAutorizacaoPessoa(HzConexao connection, string _cmpPERSID)
        {
            try
            {
                string sql = @"SELECT        acedb.bsuser.AUTHORIZATIONS.SHORTNAME, acedb.bsuser.AUTHORIZATIONS.NAME, tblAUTHPERPERSON_BIS.cmpAUTHPERSON, tblAUTHPERPERSON_BIS.cmpPERSID, 
                         tblAUTHPERPERSON_BIS.cmpAUTHID, tblAUTHPERPERSON_BIS.cmpVALIDFROM, tblAUTHPERPERSON_BIS.cmpVALIDUNTIL
                        FROM            acedb.bsuser.AUTHORIZATIONS INNER JOIN
                         tblAUTHPERPERSON_BIS ON acedb.bsuser.AUTHORIZATIONS.AUTHID = tblAUTHPERPERSON_BIS.cmpAUTHID WHERE tblAUTHPERPERSON_BIS.cmpPERSID=" + _cmpPERSID;
                return connection.loadDataTable(sql);
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao buscar a autorização da pessoa!");
            }

        }
        #endregion
    }
}
