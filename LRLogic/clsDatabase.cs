using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace LRLogic
{
    public class clsDatabase
    {
        private string strConnectionString;
        private string strSchema;

        public clsDatabase(string DBSchemma, string ConnectionString)
        {
            strConnectionString = ConnectionString;

            if (DBSchemma != "")
                strSchema = DBSchemma + ".";
            else
                strSchema = DBSchemma;
        }

        /// <summary>
        /// Calls the specified action stored procedure in the Oracle database a newly created connection is connecting to. 
        /// </summary>
        /// <param name="storedProcedureToCall">Stored procedure to call</param>
        /// <param name="parameters">array of parameters to specify</param>
        /// <returns>the amount of rows affected. This value will be -1 if the stored procedure sets ROWCOUNT to OFF or this has
        /// been disabled in the catalog by other settings.</returns>
        public int CallActionStoredProcedure(string storedProcedureToCall, OracleParameter[] parameters)
        {
            OracleCommand command = null;
            OracleConnection connectionToUse = null;
            bool connectionOpenedLocally = false;

            connectionToUse = CreateConnection();
            command = new OracleCommand(strSchema + storedProcedureToCall, connectionToUse);
            command.CommandType = CommandType.StoredProcedure;

            int toReturn = -1;
            try
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i] != null)
                    {
                        command.Parameters.Add(parameters[i]);
                    }
                }

                if (connectionToUse.State != ConnectionState.Open)
                {
                    connectionToUse.Open();
                    connectionOpenedLocally = true;
                }

                toReturn = command.ExecuteNonQuery();
            }
            finally
            {
                command.Dispose();
                if (connectionOpenedLocally)
                {
                    connectionToUse.Close();
                    connectionToUse.Dispose();
                }
            }
            return toReturn;
        }

        /// <summary>
        /// Calls the specified retrieval stored procedure in the Oracle database a newly created connection is connecting to. Fills the
        /// specified DataSet. 
        /// </summary>
        /// <param name="storedProcedureToCall">Stored procedure to call</param>
        /// <param name="parameters">array of parameters to specify</param> 
        /// <returns>true if succeeded, false otherwise</returns>
        public DataSet CallRetrievalStoredProcedure(string storedProcedureToCall, OracleParameter[] parameters)
        {
            OracleCommand command = null;
            OracleConnection connectionToUse = null;
            DataSet dataSetToFill = new DataSet();
            bool connectionOpenedLocally = false;

            connectionToUse = CreateConnection();
            command = new OracleCommand(strSchema + storedProcedureToCall, connectionToUse);

            command.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] != null)
                {
                    command.Parameters.Add(parameters[i]);
                }
            }

            try
            {
                if (connectionToUse.State != ConnectionState.Open)
                {
                    connectionToUse.Open();
                    connectionOpenedLocally = true;
                }

                using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                {
                    adapter.Fill(dataSetToFill);
                }
            }
            finally
            {
                command.Dispose();
                if (connectionOpenedLocally)
                {
                    connectionToUse.Close();
                    connectionToUse.Dispose();
                }
            }

            return dataSetToFill;
        }

        /// <summary>
        /// Executes the specified retrieval query in the Oracle database a newly created connection is connecting to. Fills the
        /// specified DataSet. 
        /// </summary>
        /// <param name="QueryToExecute">Stored procedure to call</param>   
        /// <returns>true if succeeded, false otherwise</returns>
        public DataSet CallRetrievalQuery(string QueryToExecute)
        {
            OracleCommand command = null;
            OracleConnection connectionToUse = null;
            DataSet dataSetToFill = new DataSet();
            bool connectionOpenedLocally = false;

            connectionToUse = CreateConnection();
            command = new OracleCommand(QueryToExecute, connectionToUse);

            command.CommandType = CommandType.Text;

            try
            {
                if (connectionToUse.State != ConnectionState.Open)
                {
                    connectionToUse.Open();
                    connectionOpenedLocally = true;
                }

                using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                {
                    adapter.Fill(dataSetToFill);
                }
            }
            finally
            {
                command.Dispose();
                if (connectionOpenedLocally)
                {
                    connectionToUse.Close();
                    connectionToUse.Dispose();
                }
            }

            return dataSetToFill;
        }

        /// <summary>
        /// Creates a new OracleConnection
        /// </summary>
        /// <param name="connectionString">Conectionstring To use</param>
        /// <returns>A ready to use, closed, sqlconnection object</returns>
        public OracleConnection CreateConnection()
        {
            return new OracleConnection(strConnectionString);
        }
        /// <summary>
        /// Creates a new OracleParameter 
        /// </summary>
        /// <param name="Name">Parameter Name</param>
        /// <param name="Value">Parameter Value</param>
        /// <param name="Type">Parameter OracleType</param>
        /// <param name="Directon">Parameter Direction (Input or Output)</param>
        /// <returns>A new oracle parameter</returns>
        public static OracleParameter CreateOracleParameter(string Name, object Value, OracleDbType Type, ParameterDirection Directon)
        {
            
            return new OracleParameter(Name, Type, 4000, Directon, true, 0, 0, "", System.Data.DataRowVersion.Current, Value);
        }

        public static OracleParameter CreateNumberOracleParameter(string Name, object Value, OracleDbType Type, ParameterDirection Directon, byte Precision)
        {
            return new OracleParameter(Name, Type, 4000, Directon, true, Precision, 0, "", System.Data.DataRowVersion.Current, Value);
        }

        /// <summary>
        /// Return config file value
        /// </summary>
        /// <param name="ConfigKey">Config file key parameter</param>
        /// <returns>Key Value</returns>
        public static string GetConfigValue(string ConfigKey)
        {
            return ConfigurationManager.AppSettings[ConfigKey].ToString();
        }
    }
}
