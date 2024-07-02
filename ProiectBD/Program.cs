using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            //string connection = ConfigurationManager.AppSettings.Get("StringConectareBD");
            //using (OracleConnection conn = new OracleConnection(connection))
            //{
            //    conn.Open();
            //    using (OracleCommand cmd = new OracleCommand("ALTER TABLE EMPLOYEES ADD NAME VARCHAR(50) NOT NULL", conn))
            //    {
            //        cmd.ExecuteNonQuery();
            //    //    using (OracleDataReader reader = cmd.ExecuteReader())
            //    //    {
            //    //        while (reader.Read())
            //    //        {
            //    //            for (int i = 0; i < reader.FieldCount; i++)
            //    //            {
            //    //                Console.WriteLine(reader.GetName(i) + ": " + reader.GetValue(i));
            //    //                Console.ReadLine();
            //    //            }
            //    //        }
            //    //    }
            //    }
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
}
