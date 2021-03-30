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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi Bgl = new SqlBaglantisi();

        void Temizle()
        {
            TxtKullaniciAd.Text = " ";
            TxtSifre.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand giris = new SqlCommand("select * from Tbl_PersonelGiris where KulaniciAd=@p1 and KullaniciSifre=@p2",Bgl.Baglanti());
            giris.Parameters.AddWithValue("@p1",TxtKullaniciAd.Text);
            giris.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                AnaForm frm = new AnaForm();
                frm.kullaniciAd = TxtKullaniciAd.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Kullanıcı adı veya Şifre HATALI ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Temizle();

            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
