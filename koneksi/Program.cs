using System;
using System.Collections.Generic;
using System.Data.SqlClient;//sudah terinstall dan tidak error
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Koneksi();
        }

        public void Koneksi()
        {
            using (
                SqlConnection con = new SqlConnection("data source = (Sesuai dengan server name masing - masing) ;" +
                "database=ProdiTI;User Id=sa;Password= (Sesuai dengan Password SQL Authentfication masing - masing)")
                )
            {
                con.Open();
                Console.WriteLine("Koneksi Success");
            }
        }
    }
}
