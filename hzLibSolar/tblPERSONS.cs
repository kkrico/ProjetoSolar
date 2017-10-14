using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HzLibConnection.Data;
using HzLibConnection.Sql;

namespace hzLibSolar
{
    public class tblPERSONS
    {
        /// <summary>
        /// 
        /// </summary>
        public string cmpIDPERSON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string cmpVISID { get; set; }
        public string PERSNO { get; set; }
        public string cmpPERSID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpFIRSTNAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpLASTNAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpDATEOFBIRTH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpPASSPORTNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpIDNUMBER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpPERSCLASSID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpPHONEOFFICE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpPHONEMOBILE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpEMAIL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpCOMPANYID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpNUMBERPLATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpRESERVE2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpRESERVE3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cmpREASON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string cmpAutoPERSID { get; set; }

        public List<tblAUTHPERPERSON> lstAUTHPERPERSON=new List<tblAUTHPERPERSON>();

        public void ExcluirPreCadastro(HzConexao connection, string _cmpIDPERSON)
        {
            tblAUTHPERPERSON.Excluir(connection, _cmpIDPERSON);
            Excluir(connection, _cmpIDPERSON);

        }
        public void Excluir(HzConexao connection, string _cmpIDPERSON)
        {
            string sql = "Delete [hzSolar].[dbo].[tblPERSONS] WHERE cmpIDPERSON = " + _cmpIDPERSON;
            connection.executeProcedure(sql);
        }
        public tblPERSONS()
        {
        }
        public tblPERSONS(HzConexao connection, string _PERSID)
        {
            string sql = @"SELECT        PERSID, FIRSTNAME, LASTNAME, DATEOFBIRTH, IDNUMBER, PERSCLASSID, PHONEOFFICE, PHONEMOBILE, EMAIL, COMPANYID, NUMBERPLATE, RESERVE2, RESERVE3, PERSNO, PERSCLASS
                        FROM            acedb.bsuser.PERSONS WHERE  PERSID='" + _PERSID + "' AND PERSCLASS='E'";
            DataTable dt = connection.loadDataTable(sql);

            this.cmpPERSID = dt.Rows[0]["PERSID"].ToString();
            this.cmpCOMPANYID = dt.Rows[0]["COMPANYID"].ToString();
            this.cmpDATEOFBIRTH = dt.Rows[0]["DATEOFBIRTH"].ToString();
            this.cmpEMAIL = dt.Rows[0]["EMAIL"].ToString();
            this.cmpFIRSTNAME = dt.Rows[0]["FIRSTNAME"].ToString();
            this.cmpPHONEMOBILE = dt.Rows[0]["PHONEMOBILE"].ToString();
            this.cmpIDNUMBER = dt.Rows[0]["IDNUMBER"].ToString();
            this.cmpLASTNAME = dt.Rows[0]["LASTNAME"].ToString();
            this.cmpNUMBERPLATE = dt.Rows[0]["NUMBERPLATE"].ToString();
            this.cmpPERSCLASSID = dt.Rows[0]["PERSCLASSID"].ToString();
            this.cmpPERSID = dt.Rows[0]["PERSID"].ToString();
            this.PERSNO = dt.Rows[0]["PERSNO"].ToString();
            this.cmpPHONEOFFICE = dt.Rows[0]["PHONEOFFICE"].ToString();
            this.cmpRESERVE2 = dt.Rows[0]["RESERVE2"].ToString();
            this.cmpRESERVE3 = dt.Rows[0]["RESERVE3"].ToString();


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="_cmpIDPERSON"></param>
        public tblPERSONS(HzConexao connection,string _cmpIDPERSON, string _PERSID, string Origem)
        {
            try
            {
                if (Origem == "SQL")
                {
                    try
                    {
                        string sql = @"SELECT [cmpIDPERSON],cmpVISID, [cmpPERSID], [cmpFIRSTNAME], [cmpLASTNAME], [cmpDATEOFBIRTH], [cmpPASSPORTNO], [cmpIDNUMBER], 
                [cmpPERSCLASSID], [cmpPHONEOFFICE], [cmpPHONEMOBILE], [cmpEMAIL], [cmpCOMPANYID], [cmpNUMBERPLATE], [cmpRESERVE2], [cmpRESERVE3], 
            [cmpREASON] , cmpAutoPERSID FROM [hzSolar].[dbo].[tblPERSONS] WHERE cmpIDPERSON = " + _cmpIDPERSON;
                        DataTable dt = connection.loadDataTable(sql);

                        this.cmpCOMPANYID = dt.Rows[0]["cmpCOMPANYID"].ToString();
                        this.cmpDATEOFBIRTH = dt.Rows[0]["cmpDATEOFBIRTH"].ToString();
                        this.cmpEMAIL = dt.Rows[0]["cmpEMAIL"].ToString();
                        this.cmpFIRSTNAME = dt.Rows[0]["cmpFIRSTNAME"].ToString();
                        this.cmpPHONEMOBILE = dt.Rows[0]["cmpPHONEMOBILE"].ToString();
                        this.cmpIDNUMBER = dt.Rows[0]["cmpIDNUMBER"].ToString();
                        this.cmpIDPERSON = dt.Rows[0]["cmpIDPERSON"].ToString();
                        this.cmpLASTNAME = dt.Rows[0]["cmpLASTNAME"].ToString();
                        this.cmpNUMBERPLATE = dt.Rows[0]["cmpNUMBERPLATE"].ToString();
                        this.cmpPERSCLASSID = dt.Rows[0]["cmpPERSCLASSID"].ToString();
                        this.cmpPERSID = dt.Rows[0]["cmpPERSID"].ToString();
                        this.cmpPASSPORTNO = dt.Rows[0]["cmpPASSPORTNO"].ToString();
                        this.cmpPHONEOFFICE = dt.Rows[0]["cmpPHONEOFFICE"].ToString();
                        this.cmpREASON = dt.Rows[0]["cmpREASON"].ToString();
                        this.cmpRESERVE2 = dt.Rows[0]["cmpRESERVE2"].ToString();
                        this.cmpRESERVE3 = dt.Rows[0]["cmpRESERVE3"].ToString();
                        this.cmpVISID = dt.Rows[0]["cmpVISID"].ToString();
                        this.cmpAutoPERSID = dt.Rows[0]["cmpAutoPERSID"].ToString();

                        CarregarAUTHPERPERSON(connection, _cmpIDPERSON);
                        
                    }
                    catch (Exception)
                    {
                        
                        throw new Exception("Erro ao carregar a pessoa no Banco Solar!");
                    }
                }
                else
                {
                    try
                    {
                        string sql = @"SELECT        [acedb].[bsuser].PERSONS.PERSID, [acedb].[bsuser].PERSONS.FIRSTNAME, [acedb].[bsuser].PERSONS.LASTNAME, [acedb].[bsuser].PERSONS.DATEOFBIRTH, [acedb].[bsuser].VISITORS.PASSPORTNO, [acedb].[bsuser].PERSONS.IDNUMBER, 
                         [acedb].[bsuser].PERSONS.PERSCLASSID, [acedb].[bsuser].PERSONS.PHONEOFFICE, [acedb].[bsuser].PERSONS.PHONEMOBILE, [acedb].[bsuser].PERSONS.EMAIL, [acedb].[bsuser].PERSONS.COMPANYID, [acedb].[bsuser].PERSONS.NUMBERPLATE, 
                         [acedb].[bsuser].PERSONS.RESERVE2, [acedb].[bsuser].PERSONS.RESERVE3, [acedb].[bsuser].VISITORS.REASON,acedb.bsuser.VISITORS.VISID,[acedb].[bsuser].PERSONS.PHONEPRIVATE,[acedb].[bsuser].PERSONS.RESERVE1
                            FROM            [acedb].[bsuser].PERSONS INNER JOIN
                         [acedb].[bsuser].VISITORS ON [acedb].[bsuser].PERSONS.PERSID = [acedb].[bsuser].VISITORS.PERSID WHERE [acedb].[bsuser].PERSONS.PERSID='" + _PERSID + "'";
                        DataTable dt = connection.loadDataTable(sql);

                        this.cmpPERSID = dt.Rows[0]["PERSID"].ToString();
                        this.cmpCOMPANYID = dt.Rows[0]["COMPANYID"].ToString();
                        this.cmpDATEOFBIRTH = RetornaData(dt.Rows[0]["DATEOFBIRTH"].ToString());
                        this.cmpEMAIL = dt.Rows[0]["EMAIL"].ToString();
                        this.cmpFIRSTNAME = dt.Rows[0]["FIRSTNAME"].ToString();
                        this.cmpPHONEMOBILE = dt.Rows[0]["PHONEMOBILE"].ToString();
                        this.cmpIDNUMBER = dt.Rows[0]["RESERVE1"].ToString();
                        //this.cmpIDPERSON = dt.Rows[0]["IDPERSON"].ToString();
                        this.cmpLASTNAME = dt.Rows[0]["LASTNAME"].ToString();
                        this.cmpNUMBERPLATE = dt.Rows[0]["NUMBERPLATE"].ToString();
                        this.cmpPERSCLASSID = dt.Rows[0]["PERSCLASSID"].ToString();
                        this.cmpPERSID = dt.Rows[0]["PERSID"].ToString();
                        this.cmpPASSPORTNO = dt.Rows[0]["PASSPORTNO"].ToString();
                        this.cmpPHONEOFFICE = dt.Rows[0]["PHONEPRIVATE"].ToString();
                        this.cmpREASON = dt.Rows[0]["REASON"].ToString();
                        this.cmpRESERVE2 = dt.Rows[0]["RESERVE2"].ToString();
                        this.cmpRESERVE3 = dt.Rows[0]["RESERVE3"].ToString();
                        this.cmpVISID = dt.Rows[0]["VISID"].ToString();
                    }
                    catch (Exception ex)
                    {
                        
                        throw new Exception("Erro ao carregar a pessoa no BIS!");
                    }
                }

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
             
        }

        private string RetornaData(string data)
        {
            DateTime dataOut;
            if (DateTime.TryParse(data, out dataOut) == true)
            {
                return dataOut.ToShortDateString();
            }
            if (string.IsNullOrEmpty(data) == false && data.Length==8)
            {
                string strData = String.Format(@"00/00/0000", data);

                if (DateTime.TryParse(data, out dataOut) == true)
                {
                    return dataOut.ToShortDateString();
                }
                else
                {
                    if (data.Length == 8)
                    {
                        strData = data.Substring(6, 2) + "/" +  data.Substring(4, 2) + "/" + data.Substring(0, 4);

                        if (DateTime.TryParse(strData, out dataOut) == true)
                        {
                            return dataOut.ToShortDateString();
                        }
                        else
                        { return ""; }
                    }
                    return "";
                }

            }
            else
            { return ""; }
        }

        public void CarregarAUTHPERPERSON(HzConexao connection, string _cmpIDPERSON)
        {
            lstAUTHPERPERSON =new List<tblAUTHPERPERSON>();
            DataTable dtAuto = tblAUTHPERPERSON.GETAutorizacaoPessoa(connection, _cmpIDPERSON);
            for (int i = 0; i < dtAuto.Rows.Count; i++)
            {
                tblAUTHPERPERSON autp = new tblAUTHPERPERSON();
                autp.cmpAUTHID = dtAuto.Rows[i]["cmpAUTHID"].ToString();
                autp.cmpAUTHPERSON = int.Parse(dtAuto.Rows[i]["cmpAUTHPERSON"].ToString());
                autp.cmpIDPERSON = int.Parse(dtAuto.Rows[i]["cmpIDPERSON"].ToString());
                autp.cmpVALIDFROM = DateTime.Parse(dtAuto.Rows[i]["cmpVALIDFROM"].ToString());
                autp.cmpVALIDUNTIL = DateTime.Parse(dtAuto.Rows[i]["cmpVALIDUNTIL"].ToString());
                autp.SHORTNAME = dtAuto.Rows[i]["SHORTNAME"].ToString();

                lstAUTHPERPERSON.Add(autp);
            }
        }
        /// <summary>
        /// buscar todos
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static DataTable Get(HzConexao connection)
        {
            try
            {
                string sql = @"SELECT [cmpIDPERSON], [cmpPERSID], [cmpFIRSTNAME], [cmpLASTNAME], [cmpDATEOFBIRTH8], [cmpPASSPORTNO], [cmpIDNUMBER], 
                [cmpPERSCLASSID], [cmpPHONEOFFICE], [cmpHONEMOBILE], [cmpEMAIL], [cmpCOMPANYID], [cmpNUMBERPLATE], [cmpRESERV2], [cmpRESERV3], 
            [cmpREASON],cmpVISID,cmpAutoPERSID  FROM [hzSolar].[dbo].[tblPERSONS]";
                return connection.loadDataTable(sql);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao buscar os dados no banco!"); ;
            }
        }
        /// <summary>
        /// buscar com filtro
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="ls"></param>
        /// <returns></returns>
        public static DataTable Get(HzConexao connection, ListCampos ls)
        {
            try
            {
                string sql = ListCampo.RetornaSQL(@"SELECT [cmpIDPERSON], [cmpPERSID], [cmpFIRSTNAME], [cmpLASTNAME], [cmpDATEOFBIRTH8], [cmpPASSPORTNO], [cmpIDNUMBER], 
                [cmpPERSCLASSID], [cmpPHONEOFFICE], [cmpHONEMOBILE], [cmpEMAIL], [cmpCOMPANYID], [cmpNUMBERPLATE], [cmpRESERV2], [cmpRESERV3], 
            [cmpREASON],cmpVISID,cmpAutoPERSID FROM [hzSolar].[dbo].[tblPERSONS]", ls);
                return connection.loadDataTable(sql);
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao buscar ao filtrar os dados no Banco!");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        public string Save(HzConexao connection)
        {
            try
            {
                if (cmpIDPERSON == null) { cmpIDPERSON = "0"; }
                string sql = "exec  spIncluirPersons " + cmpIDPERSON + ",'" + cmpPERSID + "','" + cmpFIRSTNAME + "','" + cmpLASTNAME + "','" + cmpDATEOFBIRTH + "','" + cmpPASSPORTNO + "','" + cmpIDNUMBER + "','" +
                    cmpPERSCLASSID + "','" + cmpPHONEOFFICE + "','" + cmpPHONEMOBILE + "','" + cmpEMAIL + "','" + cmpCOMPANYID + "','" + cmpNUMBERPLATE + "','" + cmpRESERVE2 + "','" + cmpRESERVE3 + "','" + cmpREASON + "','" + cmpPASSPORTNO + "','" +
                    cmpVISID + "','" + cmpAutoPERSID + "'";

                DataTable dt = connection.loadDataTable(sql);
                return dt.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao incluir a pessoa!");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="_cmpIDPERSON"></param>
        public static void Desativar(HzConexao connection, int _cmpIDPERSON )
        {
            try
            {
                string sql = "exec  spDesativarPessoa " + _cmpIDPERSON + "'";
                connection.executeProcedure(sql);
            }
            catch (Exception)
            {
                
                throw new Exception("Erro ao desativar a pessoa");
            }
        }

        public static DataTable GETTBancos(HzConexao connection, string NomeDoc)
        {
            try
            {
                string[] nomes = NomeDoc.Split(' ');
                string firstname = nomes[0];
                string lastname = "";
                if (nomes.Length > 1)
                {
                    lastname = NomeDoc.Substring(firstname.Length);
                }
                string sql = "EXEC [hzSolar].[dbo].sbBuscarVisitantes '" + firstname + "','" + lastname + "'";
                DataTable dt = connection.loadDataTable(sql);
                return dt;
            }
            catch (Exception ex )
            {
                
                throw new Exception("Erro ao buscar os visitantes pelo nome ou documento!");
            }
        }
        public static DataTable GETFuncionarios(HzConexao connection, string Nome)
        {
            try
            {
                string[] nomes = Nome.Split(' ');
                string firstname = nomes[0];
                string lastname = "";
                if (nomes.Length > 1)
                {
                    lastname = Nome.Substring(firstname.Length);
                }
                string sql = "EXEC [dbo].sbBuscarFuncionario '" + firstname + "','" + lastname + "'";
                DataTable dt = connection.loadDataTable(sql);
                return dt;
            }
            catch (Exception)
            {

                throw new Exception("Erro ao buscar os visitantes pelo nome ou documento!");
            }
        }
        public static bool ExisteVisitante(HzConexao connection, string passportno)
        {
            string sql = "SELECT  [cmpPASSPORTNO] FROM [hzSolar].[dbo].[tblPERSONS] where cmpPASSPORTNO='" + passportno.Trim() + "'";
            DataTable dt = connection.loadDataTable(sql);
            if (dt.Rows.Count == 0) { return false; }
            else { return true; }
        }
    }
}
 
