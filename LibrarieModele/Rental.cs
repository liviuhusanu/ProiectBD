using System;
using System.Data;

namespace LibrarieModele
{
    public class Rental
    {
        public int IdRental { get; set; }
        public int IdClient { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; }
        public int? PriceTotal { get; set; }
        public Client Client { get; set; }

        private static readonly string[] ValidStatuses = { "active", "completed", "canceled" };

        public Rental(Client client, DateTime rentalDate)
        { }
     
        public Rental(int idClient, DateTime rentalDate, DateTime? returnDate, string status, int priceTotal)
        {
            IdClient = idClient;
            RentalDate = rentalDate;
            ReturnDate = returnDate;

            if (IsValidStatus(status))
            {
                Status = status;
            }
            else
            {
                throw new ArgumentException("Status trebuie sa contina: 'active', 'completed', 'canceled'.");
            }

            PriceTotal = priceTotal;
        }

        public Rental(int idClient, DateTime rentalDate, DateTime? returnDate, string status, int priceTotal, int idRental)
        {
            IdRental = idRental;
            IdClient = idClient;
            RentalDate = rentalDate;
            ReturnDate = returnDate;

            if (IsValidStatus(status))
            {
                Status = status;
            }
            else
            {
                throw new ArgumentException("Status trebuie sa contina: 'active', 'completed', 'canceled'.");
            }

            PriceTotal = priceTotal;
        }

        public Rental(Client client, DateTime rentalDate, DateTime? returnDate, string status, int? priceTotal = null)
        {
            Client = client;
            IdClient = client.IdClient;
            RentalDate = rentalDate;
            ReturnDate = returnDate;

            if (IsValidStatus(status))
            {
                Status = status;
            }
            else
            {
                throw new ArgumentException("Status trebuie sa contina: 'active', 'completed', 'canceled'.");
            }

            PriceTotal = priceTotal;
        }

        public Rental(DataRow linieDB)
        {
            IdRental = Convert.ToInt32(linieDB["id_rental"].ToString());

            //if (linieDB.Table.Columns.Contains("id_client"))
            //{
            //    IdClient = linieDB["id_client"] == DBNull.Value ? (int?)null : Convert.ToInt32(linieDB["id_client"]);
            //}
            IdClient = Convert.ToInt32(linieDB["id_client"].ToString());

            RentalDate = Convert.ToDateTime(linieDB["rental_date"].ToString());
            ReturnDate = linieDB["return_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(linieDB["return_date"].ToString());
            Status = linieDB["status"].ToString();
            PriceTotal = linieDB["price_total"] == DBNull.Value ? (int?)null : Convert.ToInt32(linieDB["price_total"].ToString());
        }

        public static bool IsValidStatus(string status)
        {
            foreach (var validStatus in ValidStatuses)
            {
               if(validStatus.Equals(status)) { return true; }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Rental ID: {IdRental}, Client ID: {IdClient}, Client Name: {Client?.Name ?? "N/A"}, Rental Date: {RentalDate.ToShortDateString()}, " +
                   $"Return Date: {(ReturnDate.HasValue ? ReturnDate.Value.ToShortDateString() : "N/A")}, Status: {Status}, " +
                   $"Price Total: {(PriceTotal.HasValue ? PriceTotal.Value.ToString("C") : "N/A")}";
        }
        //public override string ToString()
        //{
        //    return $"Rental ID: {IdRental}, Client ID: {IdClient}, Rental Date: {RentalDate.ToShortDateString()}, Return Date: {(ReturnDate.HasValue ? ReturnDate.Value.ToShortDateString() : "N/A")}, Status: {Status}, Price Total: {(PriceTotal.HasValue ? PriceTotal.Value.ToString("F2") : "N/A")}";
        //}
    }
}

