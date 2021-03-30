using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace personel
{
    class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-O48QP1T;Initial Catalog=NesneTabanlıVeriTabani;Integrated Security=True");
            Baglan.Open();
            return Baglan;
        }

       
    }
}
