using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HzLibConnection.Data;
using System.Data;
using HzLibConnection.Sql;
using System.DirectoryServices.Protocols;
using System.Net;

namespace hzLibSolar
{
    public class tblPERMISSOES
    {
        public string cmpIDPERMISSOES { get; set; }

        public string cmpPERSID { get; set; }

        public string cmpLOGINREDE { get; set; }

        public bool cmpADMINISTRADOR { get; set; }


        public tblPERMISSOES()
        { 
        
        }
        public static bool LoginRede(string user, string pwd, string dominio)
        {
            try
            {
                LdapConnection lcon = new LdapConnection
          (new LdapDirectoryIdentifier((string)null, false, false));
                NetworkCredential nc = new NetworkCredential(user, pwd, dominio);
                lcon.Credential = nc;
                lcon.AuthType = AuthType.Negotiate;

                lcon.Bind(nc);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("O login ou senha de rede está incorreta! " + ex.Message);
            }
        }
        public static bool LoginBIS(HzConexao connection, string loginRede)
        {
            string sql = @"select [cmpIDPERMISSOES] ,[cmpPERSID] ,[cmpLOGINREDE] ,[cmpADMINISTRADOR] FROM [hzSolar].[dbo].[tblPERMISSOES] 
                                       WHERE cmpLOGINREDE = '" + loginRede.Trim() + "'";
              DataTable   dt = connection.loadDataTable(sql);
              if (dt.Rows.Count > 0)
              { return true; }
              else { return false; }
        }
        public static string AuthoBIS(HzConexao connection, string loginRede)
        {
            string sql = @"select [cmpPERSID] FROM [hzSolar].[dbo].[tblPERMISSOES] 
                                       WHERE cmpLOGINREDE = '" + loginRede.Trim() + "'";
            DataTable dt = connection.loadDataTable(sql);
            if (dt.Rows.Count > 0)
            { return dt.Rows[0]["cmpPERSID"].ToString(); }
            else { return ""; }
        }
        public tblPERMISSOES(HzConexao connection, string _cmpIDPERMISSOES, string cmpPERSID)
        {
            DataTable dt;
            if (string.IsNullOrEmpty(_cmpIDPERMISSOES) == false)
            {
                string sql = @"select [cmpIDPERMISSOES] ,[cmpPERSID] ,[cmpLOGINREDE] ,[cmpADMINISTRADOR] FROM [hzSolar].[dbo].[tblPERMISSOES] 
                                       WHERE cmpIDPERMISSOES = " + _cmpIDPERMISSOES;
                dt = connection.loadDataTable(sql);
            }
            else
            {
                string sql = @"select [cmpIDPERMISSOES] ,[cmpPERSID] ,[cmpLOGINREDE] ,[cmpADMINISTRADOR] FROM [hzSolar].[dbo].[tblPERMISSOES] 
                                       WHERE cmpPERSID = '" + cmpPERSID + "'";
                dt = connection.loadDataTable(sql);
            }

            if(dt.Rows.Count>0)
            {
                this.cmpADMINISTRADOR = bool.Parse(dt.Rows[0]["cmpADMINISTRADOR"].ToString());
                this.cmpIDPERMISSOES = dt.Rows[0]["cmpIDPERMISSOES"].ToString();
                this.cmpLOGINREDE = dt.Rows[0]["cmpLOGINREDE"].ToString();
                this.cmpPERSID = dt.Rows[0]["cmpPERSID"].ToString();
            }

        }
        public static DataTable Get(HzConexao connection, ListCampos ls)

        {
        string sql = ListCampo.RetornaSQL(@"select [cmpIDPERMISSOES] ,[cmpPERSID] ,[cmpLOGINREDE] ,[cmpADMINISTRADOR] FROM [hzSolar].[dbo].[tblPERMISSOES] ", ls);
                return connection.loadDataTable(sql);
        }

        public void Save(HzConexao connection)
        {
            if (string.IsNullOrEmpty(cmpIDPERMISSOES)==true) { cmpIDPERMISSOES = "0"; }
            string sql = "exec  dbo.spIncluirPermissoes " + cmpIDPERMISSOES + ",'" + cmpPERSID + "','" + cmpLOGINREDE + "','" + cmpADMINISTRADOR + "'";
            connection.executeProcedure(sql);
        }

        public static void Excluir(HzConexao connection, string _cmpIDPERMISSOES)

        {
            string sql = "exec spExcluirPermissao " + _cmpIDPERMISSOES;
            connection.executeProcedure(sql);
        }

        

  }
      
      }


