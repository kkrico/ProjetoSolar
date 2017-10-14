using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HzLibConnection.Data;
using HzLibConnection.Sql;

namespace hzLibSolar
{
    /// <summary>
    /// Classe que gerencia os dados da tabela tblAUTHPERPERSON.
    /// </summary>
    public  class tblAUTHPERPERSON
    {
      #region Variaveis
		  
        /// <summary>
        /// Chave primaria da tabela.
        /// </summary>
        public int cmpAUTHPERSON { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tblPERSONS.
        /// </summary>
        public int cmpIDPERSON { get; set; }
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
        /// 
        public string SHORTNAME{ get; set; }
	#endregion

        #region Funções
        public tblAUTHPERPERSON()
        {

        }
        public tblAUTHPERPERSON(HzConexao connection, string _cmpAUTHPERSON)
        {
            string sql = "SELECT [cmpAUTHPERSON] ,[cmpIDPERSON] ,[cmpAUTHID] ,[cmpVALIDFROM]  ,[cmpVALIDUNTIL] FROM [hzSolar].[dbo].[tblAUTHPERPERSON] where cmpAUTHPERSON=" + _cmpAUTHPERSON;
            DataTable dt = connection.loadDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                this.cmpAUTHID = dt.Rows[0]["cmpAUTHID"].ToString();
                this.cmpAUTHPERSON = int.Parse(dt.Rows[0]["cmpAUTHPERSON"].ToString());
                this.cmpIDPERSON = int.Parse(dt.Rows[0]["cmpIDPERSON"].ToString());
                this.cmpVALIDFROM = DateTime.Parse(dt.Rows[0]["cmpVALIDFROM"].ToString());
                this.cmpVALIDUNTIL = DateTime.Parse(dt.Rows[0]["cmpVALIDUNTIL"].ToString());
            }
        }
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
                string sql = "SELECT [cmpAUTHPERSON] ,[cmpIDPERSON] ,[cmpAUTHID] ,[cmpVALIDFROM]  ,[cmpVALIDUNTIL] FROM [hzSolar].[dbo].[tblAUTHPERPERSON]";
                return connection.loadDataTable(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao carregar as autorizações por pessoas!");
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
                string sql = ListCampo.RetornaSQL("SELECT [cmpAUTHPERSON] ,[cmpIDPERSON] ,[cmpAUTHID] ,[cmpVALIDFROM]  ,[cmpVALIDUNTIL] FROM [hzSolar].[dbo].[tblAUTHPERPERSON]", ls);
                return connection.loadDataTable(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar as autorizações por pessoa!") ;
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
                string sql = "exec  spIncluirAutorizacao " + cmpIDPERSON + ",'" + cmpAUTHID + "','" + cmpVALIDFROM + "','" + cmpVALIDUNTIL + "'";
                connection.executeProcedure(sql);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao incluira autorização!");
            }
        }
        /// <summary>
        /// Exclui os dados gravados da tabela.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="_cmpIDPERSON"></param>
        /// <param name="_cmpAUTHID"></param>
        public static void Excluir(HzConexao connection, string _cmpIDPERSON)
        {
            try
            {
                string sql = "exec  [hzSolar].[dbo].spExcluirAUTHPERPERSON " + _cmpIDPERSON;
                connection.executeProcedure(sql);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao exlcuir a atorização por pessoa!");
            }
        }
        /// <summary>
        /// Dados da autorização 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="_cmpIDPERSON"></param>
        /// <returns></returns>
        public static DataTable GETAutorizacaoPessoa(HzConexao connection, string _cmpIDPERSON)
        {
            try
            {
                string sql = @"SELECT        hzSolar.dbo.tblAUTHPERPERSON.cmpAUTHPERSON, hzSolar.dbo.tblAUTHPERPERSON.cmpIDPERSON, hzSolar.dbo.tblAUTHPERPERSON.cmpAUTHID, hzSolar.dbo.tblAUTHPERPERSON.cmpVALIDFROM, 
                         hzSolar.dbo.tblAUTHPERPERSON.cmpVALIDUNTIL, [acedb].[bsuser].AUTHORIZATIONS.SHORTNAME, [acedb].[bsuser].AUTHORIZATIONS.NAME
                         FROM            hzSolar.dbo.tblAUTHPERPERSON INNER JOIN
                         [acedb].[bsuser].AUTHORIZATIONS ON hzSolar.dbo.tblAUTHPERPERSON.cmpAUTHID = [acedb].[bsuser].AUTHORIZATIONS.AUTHID WHERE hzSolar.dbo.tblAUTHPERPERSON.cmpIDPERSON=" + _cmpIDPERSON;
                return connection.loadDataTable(sql);
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao buscar a autorização da pessoa!");
            }

        }

        public static List<tblAUTHPERPERSON> GetlstAUTHPERPERSON(HzConexao connection, string _cmpIDPERSON)
        {
            List<tblAUTHPERPERSON> lst = new List<tblAUTHPERPERSON>();
            DataTable dt = GETAutorizacaoPessoa(connection, _cmpIDPERSON);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tblAUTHPERPERSON auto = new tblAUTHPERPERSON();
                auto.cmpAUTHID = dt.Rows[0]["cmpAUTHID"].ToString();
                auto.cmpAUTHPERSON = int.Parse(dt.Rows[0]["cmpAUTHPERSON"].ToString());
                auto.cmpIDPERSON = int.Parse(dt.Rows[0]["cmpIDPERSON"].ToString());
                auto.cmpVALIDFROM = DateTime.Parse(dt.Rows[0]["cmpVALIDFROM"].ToString());
                auto.cmpVALIDUNTIL = DateTime.Parse(dt.Rows[0]["cmpVALIDUNTIL"].ToString());
                auto.SHORTNAME = dt.Rows[0]["SHORTNAME"].ToString();
                lst.Add(auto);
            }
            return lst;
        }
        #endregion
        
    }
}
