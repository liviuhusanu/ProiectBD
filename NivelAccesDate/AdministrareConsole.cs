using System;
using System.Collections.Generic;
using System.Data;

using NivelAccesDate;

using Oracle.ManagedDataAccess.Client;

namespace LibrarieModele
{
    public class AdministrareConsole
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddConsola(Consola consola)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "INSERT INTO CONSOLES VALUES (console_seq.nextval, :Name, :Manufacturer, :Quantity, :Available, :PriceDay)",
                    CommandType.Text,
                    new OracleParameter(":Name", OracleDbType.NVarchar2, consola.Name, ParameterDirection.Input),
                    new OracleParameter(":Manufacturer", OracleDbType.NVarchar2, consola.Manufacturer, ParameterDirection.Input),
                    new OracleParameter(":Quantity", OracleDbType.Int32, consola.Quantity, ParameterDirection.Input),
                    new OracleParameter(":Available", OracleDbType.Int32, consola.Available, ParameterDirection.Input),
                    new OracleParameter(":PriceDay", OracleDbType.Decimal, consola.PriceDay, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        public List<Consola> GetConsole()
        {
            var result = new List<Consola>();
            var dsConsole = SqlDBHelper.ExecuteDataSet("select * from CONSOLES", CommandType.Text);

            foreach (DataRow linieDB in dsConsole.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Consola(linieDB));
            }
            return result;
        }

        public Consola GetConsola(int id)
        {
            Consola result = null;
            var dsConsole = SqlDBHelper.ExecuteDataSet("select * from Consoles where IdConsole = :IdConsole", CommandType.Text,
                new OracleParameter(":IdConsole", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsConsole.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsConsole.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Consola(linieDB);
            }
            return result;
        }

        public bool UpdateConsola(Consola consola)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "UPDATE consoles SET name = :Name, manufacturer = :Manufacturer, quantity = :Quantity, available = :Available, price_day = :PriceDay WHERE id_console = :IdConsole", CommandType.Text,
                    new OracleParameter(":Name", OracleDbType.NVarchar2, consola.Name, ParameterDirection.Input),
                    new OracleParameter(":Manufacturer", OracleDbType.NVarchar2, consola.Manufacturer, ParameterDirection.Input),
                    new OracleParameter(":Quantity", OracleDbType.Int32, consola.Quantity, ParameterDirection.Input),
                    new OracleParameter(":Available", OracleDbType.Int32, consola.Available, ParameterDirection.Input),
                    new OracleParameter(":PriceDay", OracleDbType.Decimal, consola.PriceDay, ParameterDirection.Input),
                    new OracleParameter(":IdConsole", OracleDbType.Int32, consola.IdConsole, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        public bool DeleteConsola(int idConsole)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "DELETE FROM consoles WHERE id_console = :IdConsole", CommandType.Text,
                    new OracleParameter(":IdConsole", OracleDbType.Int32, idConsole, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
