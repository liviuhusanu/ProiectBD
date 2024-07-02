using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.IO;

namespace NivelAccesDate
{
    /// <summary>
    /// contine metode generice de interogare, respectiv actualizare a bazei de date
    /// </summary>
    public static class SqlDBHelper
    {
        private const int EROARE_LA_EXECUTIE = 0;

        private static string _connectionString = null;
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = ConfigurationManager.AppSettings.Get("StringConectareBD");
                }
                return _connectionString;
            }
        }

        /// <summary>
        /// executa o instructiune de tip SELECT
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns>returneaza valorile primite ca un obiect generic de tip 'DataSet'</returns>
        public static DataSet ExecuteDataSet(string sql, CommandType cmdType, params OracleParameter[] parameters)
        {
            using (DataSet ds = new DataSet())
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }


                    try
                    {
                        new OracleDataAdapter(cmd).Fill(ds);
                    }
                    catch (OracleException ex)
                    {
                        LogError(ex, sql);
                        Console.WriteLine($"OracleException: {ex.Message}");
                        // Optionally, you can rethrow the exception if you want to fail the test
                        throw;
                    }
                    return ds;
                }
            }
        }

        /// <summary>
        /// executa instructiuni INSERT/UPDATE/DELETE 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns> returneaza 'true' daca instructiunea a fost executata cu success</returns>
        public static bool ExecuteNonQuery(string sql, CommandType cmdType, params OracleParameter[] parameters)
        {
            int rezult = EROARE_LA_EXECUTIE;
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        cmd.Connection.Open();
                        rezult = cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        LogError(ex, sql);
                        //salveaza exceptii in fisiere log
                    }
                }
            }
            return Convert.ToBoolean(rezult);
        }
        private static void LogError(Exception ex, string sql)
        {
            string logFilePath = "C:\\Users\\Liviu\\source\\repos\\ProiectBD\\ProiectBD\\log.txt"; // Specify the path to your log file

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine("Date: " + DateTime.Now.ToString());
                    writer.WriteLine("Message: " + ex.Message);
                    writer.WriteLine("Stack Trace: " + ex.StackTrace);
                    writer.WriteLine("SQL: ", sql.ToString());
                    writer.WriteLine("---------------------------------------------------");
                }
            }
            catch (IOException ioEx)
            {
                // Handle potential errors writing to the log file
                Console.WriteLine("Error writing to log file: " + ioEx.Message);
            }
        }
    }
}
