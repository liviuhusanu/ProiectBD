using System;
using System.Data;
using System.Text.RegularExpressions;

namespace LibrarieModele
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Client()
        { }
        
        public Client(string name, string email, string phone)
        {
            Name = name;

            if (Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$") && email.Length >= 12 && email.Length <= 50)
            {
                Email = email;
            }
            else
            {
                //throw new ArgumentException("Introdu emailu in formatul nume.prenume@email.com.");
            }
            Phone = phone;
        }
        public Client(string name, string email, string phone, int idClient)
        {
            IdClient = idClient;
            Name = name;

            if(Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$") && email.Length >= 12 && email.Length <= 50)
            {
                Email = email;
            }
            else
            {
                throw new ArgumentException("Introdu emailu in formatul nume.prenume@email.com.");
            }
            Phone = phone;
        }

        public Client(DataRow linieDB)
        {
            IdClient = Convert.ToInt32(linieDB["id_client"].ToString());
            Name = linieDB["name"].ToString();
            Email = linieDB["email"].ToString();
            Phone = linieDB["phone"].ToString();
        }
    }
}
