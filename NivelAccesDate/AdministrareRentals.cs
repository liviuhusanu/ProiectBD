using System;
using System.Collections.Generic;
using System.Data;

using NivelAccesDate;

using Oracle.ManagedDataAccess.Client;

namespace LibrarieModele
{
    public class AdministrareRentals
    {
        AdministrareClienti administrareClienti = new AdministrareClienti();

        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddRental(Rental rental)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "INSERT INTO Rentals VALUES (rental_seq.nextval, :IdClient, :RentalDate, :ReturnDate, :Status, :PriceTotal)",
                    CommandType.Text,
                    new OracleParameter(":IdClient", OracleDbType.Int32, rental.IdClient, ParameterDirection.Input),
                    new OracleParameter(":RentalDate", OracleDbType.Date, rental.RentalDate, ParameterDirection.Input),
                    new OracleParameter(":ReturnDate", OracleDbType.Date, rental.ReturnDate, ParameterDirection.Input),
                    new OracleParameter(":Status", OracleDbType.Varchar2, rental.Status, ParameterDirection.Input),
                    new OracleParameter(":PriceTotal", OracleDbType.Int32, rental.PriceTotal, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        //public List<Rental> GetRentals()
        //{
        //    string sql = "SELECT * " +
        //                "FROM RENTALS";

        //    var result = new List<Rental>();
        //    var dsRentals = SqlDBHelper.ExecuteDataSet(sql, CommandType.Text);

        //    foreach (DataRow linieDB in dsRentals.Tables[PRIMUL_TABEL].Rows)
        //    {
        //        var rental = new Rental(linieDB);
        //        rental.Client = administrareClienti.GetClient(rental.IdClient);
        //        result.Add(rental);
        //    }
        //    return result;
        //}
        public List<Rental> GetRentals(bool populate = false)
        {
            string sql;

            if (populate)
            {
                sql = "SELECT r.id_rental, r.id_client, r.rental_date, r.return_date, r.status, r.price_total, c.name AS client_name " +
                      "FROM Rentals r " +
                      "JOIN Clients c ON r.id_client = c.id_client";
            }
            else
            {
                sql = "SELECT * FROM Rentals";
            }

            var result = new List<Rental>();
            var dsRentals = SqlDBHelper.ExecuteDataSet(sql, CommandType.Text);

            foreach (DataRow linieDB in dsRentals.Tables[PRIMUL_TABEL].Rows)
            {
                var rental = new Rental(linieDB);
                if (populate)
                {
                    rental.Client = new Client
                    {
                        IdClient = rental.IdClient,
                        Name = linieDB["client_name"].ToString()
                    };
                }
                //else
                //{
                //    rental.Client = administrareClienti.GetClient(rental.IdClient);
                //}
                result.Add(rental);
            }
            return result;
        }




        public Rental GetRental(int id)
        {
            Rental result = null;
            var dsRental = SqlDBHelper.ExecuteDataSet("SELECT * FROM Rentals WHERE IdRental = :IdRental", CommandType.Text,
                new OracleParameter(":IdRental", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsRental.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsRental.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Rental(linieDB);
            }
            return result;
        }

        public bool UpdateRental(Rental rental)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "UPDATE Rentals SET id_client = :IdClient, rental_date = :RentalDate, return_date = :ReturnDate, status = :Status, price_total = :PriceTotal WHERE id_rental = :IdRental",
                    CommandType.Text,
                    new OracleParameter(":IdClient", OracleDbType.Int32, rental.IdClient, ParameterDirection.Input),
                    new OracleParameter(":RentalDate", OracleDbType.Date, rental.RentalDate, ParameterDirection.Input),
                    new OracleParameter(":ReturnDate", OracleDbType.Date, rental.ReturnDate, ParameterDirection.Input),
                    new OracleParameter(":Status", OracleDbType.Varchar2, rental.Status, ParameterDirection.Input),
                    new OracleParameter(":PriceTotal", OracleDbType.Int32, rental.PriceTotal, ParameterDirection.Input),
                    new OracleParameter(":IdRental", OracleDbType.Int32, rental.IdRental, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        public bool DeleteRental(int idRental)
        {
            try
            {
                return SqlDBHelper.ExecuteNonQuery(
                    "DELETE FROM RENTALS WHERE id_rental = :IdRental", CommandType.Text,
                    new OracleParameter(":IdRental", OracleDbType.Int32, idRental, ParameterDirection.Input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
