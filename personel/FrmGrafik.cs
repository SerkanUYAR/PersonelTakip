using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace personel
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlBaglantisi Bgl = new SqlBaglantisi();

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            // Grafik 1
            SqlCommand G1 = new SqlCommand("select ŞEHİR,count(*) From Tbl_Personel Group By ŞEHİR", Bgl.Baglanti());
            SqlDataReader dr1 = G1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);

            }

            // Grafik 2
            SqlCommand G2 = new SqlCommand("select MESLEK,AVG(MAAŞ) From Tbl_Personel Group By MESLEK ", Bgl.Baglanti());
            SqlDataReader dr2 = G2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Maaş"].Points.AddXY(dr2[0], dr2[1]);
            }



            Bgl.Baglanti().Close();
        }
    }
}
