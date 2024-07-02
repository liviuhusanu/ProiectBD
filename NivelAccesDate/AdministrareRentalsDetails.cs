using System;
using System.Collections.Generic;
using System.Data;

using NivelAccesDate;

using Oracle.ManagedDataAccess.Client;

namespace LibrarieModele
{
    public class AdministrareRentalsDetails
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddRentalDetails(RentalDetails rentalDetails)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "INSERT INTO RentalsDetails VALUES (rentaldet_seq.NEXTVAL, :IdRental, :IdConsole, :Quantity)",
                    CommandType.Text,
                    new OracleParameter(":IdRentalDetails", OracleDbType.Int32, rentalDetails.IdRentalDetails, ParameterDirection.Input),
                    new OracleParameter(":IdRental", OracleDbType.Int32, rentalDetails.IdRental, ParameterDirection.Input),
                    new OracleParameter(":IdConsole", OracleDbType.Int32, rentalDetails.IdConsole, ParameterDirection.Input),
                    new OracleParameter(":Quantity", OracleDbType.Int32, rentalDetails.Quantity, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        //public List<RentalDetails> GetRentalDetails()
        //{
        //    string sql = "SELECT \r\n    rd.id_rentaldetails, \r\n    rd.id_rental, \r\n    c.name AS console_name, \r\n    rd.quantity \r\nFROM \r\n    RentalsDetails rd, Consoles c \r\nWHERE \r\n    rd.id_console = c.id_console";

        //    var result = new List<RentalDetails>();
        //    var dsRentalDetails = SqlDBHelper.ExecuteDataSet(sql, CommandType.Text);

        //    foreach (DataRow linieDB in dsRentalDetails.Tables[PRIMUL_TABEL].Rows)
        //    {
        //        result.Add(new RentalDetails(linieDB));
        //    }
        //    return result;
        //}

        public List<RentalDetails> GetRentalsDetails(bool populate = false)
        {
            string sql;

            if (populate)
            {
                sql = "SELECT \r\n rd.id_console,  \r\n   rd.id_rentaldetails, \r\n    rd.id_rental, \r\n    c.name AS console_name, \r\n    rd.quantity \r\nFROM \r\n    RentalsDetails rd, Consoles c \r\nWHERE \r\n    rd.id_console = c.id_console";
            }
            else
            {
                sql = "SELECT * FROM RentalsDetails";
            }

            var result = new List<RentalDetails>();
            var dsRentalsDetails = SqlDBHelper.ExecuteDataSet(sql, CommandType.Text);

            foreach (DataRow linieDB in dsRentalsDetails.Tables[PRIMUL_TABEL].Rows)
            {
                var rentalDetails = new RentalDetails(linieDB);
                if (populate)
                {
                    rentalDetails.Consola = new Consola
                    {
                        IdConsole = rentalDetails.IdConsole,
                        Name = linieDB["console_name"].ToString()
                    };
                }
                //else
                //{
                //    rental.Client = administrareClienti.GetClient(rental.IdClient);
                //}
                result.Add(rentalDetails);
            }
            return result;
        }

        public RentalDetails GetRentalDetails(int id)
        {
            RentalDetails result = null;
            var dsRentalDetails = SqlDBHelper.ExecuteDataSet("SELECT * FROM RentalsDetails WHERE IdRentalDetails = :IdRentalDetails", CommandType.Text,
                new OracleParameter(":IdRentalDetails", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsRentalDetails.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsRentalDetails.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new RentalDetails(linieDB);
            }
            return result;
        }

        public bool UpdateRentalDetails(RentalDetails rentalDetails)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "UPDATE RentalsDetails SET id_rental = :IdRental, id_console = :IdConsole, quantity = :Quantity WHERE id_rentaldetails = :IdRentalDetails",
                    CommandType.Text,
                    new OracleParameter(":IdRental", OracleDbType.Int32, rentalDetails.IdRental, ParameterDirection.Input),
                    new OracleParameter(":IdConsole", OracleDbType.Int32, rentalDetails.IdConsole, ParameterDirection.Input),
                    new OracleParameter(":Quantity", OracleDbType.Int32, rentalDetails.Quantity, ParameterDirection.Input),
                    new OracleParameter(":IdRentalDetails", OracleDbType.Int32, rentalDetails.IdRentalDetails, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
