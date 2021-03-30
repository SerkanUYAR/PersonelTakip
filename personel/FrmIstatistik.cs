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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        SqlBaglantisi Bgl = new SqlBaglantisi();

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            this.Hide();
        }

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {

            // Toplam Personel Sayısı :
            SqlCommand Komut1 = new SqlCommand("Select count(*) from Tbl_Personel",Bgl.Baglanti());
            SqlDataReader dr = Komut1.ExecuteReader();
            while (dr.Read())
            {
                LblPerSayısı.Text = dr[0].ToString();
            }

            // Evli Personel Sayısı :

            SqlCommand Komut2 = new SqlCommand("select count(*) from Tbl_Personel where MEDENİ_HAL='EVLİ' ",Bgl.Baglanti());
            SqlDataReader dr2 = Komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvli.Text = dr2[0].ToString();
            }

            //Bekar Personel Sayısı :

            SqlCommand Komut3 = new SqlCommand("select count(*) from Tbl_Personel where MEDENİ_HAL='BEKAR' ", Bgl.Baglanti());
            SqlDataReader dr3 = Komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekar.Text = dr3[0].ToString();
            }

            // Farklı  Şehir Sayısı :
            SqlCommand Komut4 = new SqlCommand(" Select Count(distinct(Şehir)) From Tbl_Personel  ", Bgl.Baglanti());
            SqlDataReader dr4 = Komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehir.Text = dr4[0].ToString();
            }

            // Personel Toplam Maaş

            SqlCommand Komut5 = new SqlCommand("select sum(MAAŞ) From Tbl_Personel ",Bgl.Baglanti());
            SqlDataReader dr5 = Komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblToplamMaaş.Text = dr5[0].ToString();
            }


            //Personel Ortalama Maaş  :

            SqlCommand Komut6 = new SqlCommand("Select AVG(MAAŞ) From Tbl_Personel",Bgl.Baglanti());
            SqlDataReader dr6 = Komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString();
            }
        }
    }
}
