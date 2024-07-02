using System;
using System.Data;
using System.Net.Sockets;

namespace LibrarieModele
{
    public class RentalDetails
    {
        public int IdRentalDetails { get; set; }
        public int IdRental { get; set; }
        public int IdConsole { get; set; }
        public int Quantity { get; set; }
        public Consola Consola { get; set; }

        public RentalDetails()
        { }

        public RentalDetails(int idRental, int idConsole, int quantity)
        {
            IdRental = idRental;
            IdConsole = idConsole;
            Quantity = quantity;
        }

        public RentalDetails(int idRental, int idConsole, int quantity, int idRentalDetails)
        {
            IdRentalDetails = idRentalDetails;
            IdRental = idRental;
            IdConsole = idConsole;
            Quantity = quantity;
        }

        public RentalDetails(DataRow linieDB)
        {
            IdRentalDetails = Convert.ToInt32(linieDB["id_rentaldetails"].ToString());
            IdRental = Convert.ToInt32(linieDB["id_rental"].ToString());
            //if (linieDB.Table.Columns.Contains("id_console"))
            //{
            //    IdConsole = linieDB["id_console"] == DBNull.Value ? (int?)null : Convert.ToInt32(linieDB["id_console"]);
            //}

            IdConsole = Convert.ToInt32(linieDB["id_console"].ToString());
            Quantity = Convert.ToInt32(linieDB["quantity"].ToString());
        }
    }
}
