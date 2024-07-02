using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Consola
    {
        public int IdConsole { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
        public int Available { get; set; }
        public decimal PriceDay { get; set; }

        public Consola()
        { }

        public Consola(string name, string manufacturer, int quantity, int available, decimal priceDay)
        {
            Name = name;
            Manufacturer = manufacturer;
            Quantity = quantity;
            Available = available;
            PriceDay = priceDay;
        }

        public Consola(string name, string manufacturer, int quantity, int available, decimal priceDay, int idConsole)
        {
            IdConsole = idConsole;
            Name = name;
            Manufacturer = manufacturer;
            Quantity = quantity;
            Available = available;
            PriceDay = priceDay;
        }

        public Consola(DataRow linieDB)
        {
            IdConsole = Convert.ToInt32(linieDB["id_console"].ToString());
            Name = linieDB["name"].ToString();
            Manufacturer = linieDB["manufacturer"].ToString();
            Quantity = Convert.ToInt32(linieDB["quantity"].ToString());
            Available = Convert.ToInt32(linieDB["available"].ToString());
            PriceDay = Convert.ToDecimal(linieDB["price_day"].ToString());
        }
    }
}
