using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;

using NivelAccesDate;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AdministrareConsole.AddConsola(console20));

            AdministrareConsole administrareConsole = new AdministrareConsole();
            
            AdministrareRentals administrareRentals = new AdministrareRentals();

            AdministrareRentalsDetails administrareRentalsDetails = new AdministrareRentalsDetails();

            AdministrareClienti administrareClienti = new AdministrareClienti();
            
            List<Client> clients_list = administrareClienti.GetClients();
            List<Consola> console_list = administrareConsole.GetConsole();
            List<Rental> rental_list = administrareRentals.GetRentals();

            List<RentalDetails> rentals_details_list = administrareRentalsDetails.GetRentalsDetails();
            //administrareRentals.describe();

            //Rental newRental = new Rental
            //{
            //    IdClient = 7,
            //    RentalDate = DateTime.Parse("2024-06-01"),
            //    ReturnDate = DateTime.Parse("2024-06-10"),
            //    Status = "active"
            //};

            //bool rentalAdded = administrareRentals.AddRental(newRental);

            //if (rentalAdded)
            //{
            //    Console.WriteLine("Rental added successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to add rental.");
            //}

            //foreach (Rental rd in rental_list)
            //{
            //    Console.WriteLine(rd.PriceTotal);
            //}

            foreach (Rental rd in rental_list)
            {
                Console.WriteLine(rd.Client.Name);
            }

            Console.ReadLine();
        }
    }
}
