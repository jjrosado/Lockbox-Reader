using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace LRLogic
{
    public class ValidateCode
    {
        public static string ExistInvoiceOrContract(string code, decimal amount)
        {
            DataSet ds = new DataSet();
            clsDatabase objDatabase = new clsDatabase("", ConfigurationManager.ConnectionStrings["WinLockboxReader.Properties.Settings.Setting"].ConnectionString);

            OracleParameter[] objParameters = new OracleParameter[3];

            objParameters[0] = clsDatabase.CreateOracleParameter("code", code, OracleDbType.Varchar2, ParameterDirection.Input);
            objParameters[1] = clsDatabase.CreateOracleParameter("amount", amount, OracleDbType.Double, ParameterDirection.Input);
            objParameters[2] = clsDatabase.CreateOracleParameter("results", String.Empty, OracleDbType.Varchar2, ParameterDirection.Output);

            objDatabase.CallRetrievalStoredProcedure("OM_LOCKBOX_VALIDATION_JOB", objParameters);

            return objParameters[2].Value.ToString();
        }
    }
}
