using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HzLibConnection.Data;
using System.Data;

namespace hzLibSolar.BIS
{
    public class Persons
    {
        public static bool ExisteVisitante(HzConexao connection,string passportno)
        {
            string sql = "SELECT   PASSPORTNO  FROM [acedb].[bsuser].[VISITORS] where PASSPORTNO='" + passportno.Trim() + "'";
            DataTable dt = connection.loadDataTable(sql);
            if (dt.Rows.Count == 0) { return false; }
            else { return true; }
        }
    }
}
