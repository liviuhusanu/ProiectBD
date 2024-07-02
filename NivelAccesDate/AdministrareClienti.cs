using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;

using Oracle.ManagedDataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareClienti
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public bool AddClient(Client client)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "INSERT INTO CLIENTS VALUES (client_seq.nextval, :Name, :Email, :Phone)", CommandType.Text,
                    new OracleParameter(":Name", OracleDbType.NVarchar2, client.Name, ParameterDirection.Input),
                    new OracleParameter(":Email", OracleDbType.NVarchar2, client.Email, ParameterDirection.Input),
                    new OracleParameter(":Phone", OracleDbType.NVarchar2, client.Phone, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        public List<Client> GetClients()
        {
            var result = new List<Client>();
            var dsClients = SqlDBHelper.ExecuteDataSet("SELECT * FROM CLIENTS", CommandType.Text);

            foreach (DataRow linieDB in dsClients.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Client(linieDB));
            }
            return result;
        }

        public Client GetClient(int? id)
        {
            Client result = null;
            var dsClients = SqlDBHelper.ExecuteDataSet("SELECT * FROM CLIENTS WHERE Id_Client = :IdClient", CommandType.Text,
                new OracleParameter(":IdClient", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsClients.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsClients.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Client(linieDB);
            }
            return result;
        }

        public Client GetClientByEmail(string email)
        {
            string sql = "SELECT id_client, name, email, phone FROM Clients WHERE email = :Email";

            OracleParameter[] parameters = {
        new OracleParameter(":Email", OracleDbType.Varchar2) { Value = email }
    };

            DataSet dsClient;
            try
            {
                dsClient = SqlDBHelper.ExecuteDataSet(sql, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here
                return null; // Or handle the error appropriately
            }

            if (dsClient.Tables.Count == 0 || dsClient.Tables[0].Rows.Count == 0)
            {
                return null; // No client found with the given email
            }

            DataRow row = dsClient.Tables[0].Rows[0];
            return new Client(row);
        }

        public bool UpdateClient(Client client)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "UPDATE clients SET name = :Name, email = :Email, phone = :Phone WHERE id_client = :IdClient", CommandType.Text,
                    new OracleParameter(":Name", OracleDbType.NVarchar2, client.Name, ParameterDirection.Input),
                    new OracleParameter(":Email", OracleDbType.NVarchar2, client.Email, ParameterDirection.Input),
                    new OracleParameter(":Phone", OracleDbType.NVarchar2, client.Phone, ParameterDirection.Input),
                    new OracleParameter(":IdClient", OracleDbType.Int32, client.IdClient, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        public bool DeleteClient(int clientId)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "DELETE FROM clients WHERE id_client = :IdClient", CommandType.Text,
                    new OracleParameter(":IdClient", OracleDbType.Int32, clientId, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
