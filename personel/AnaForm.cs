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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        public string kullaniciAd;

        private void Temizle()
        {
            txtid.Text = " ";
            txtad.Text = " ";
            txtsoyad.Text = " ";
            cmbsehir.Text = " ";
            mskmaas.Text = " ";
            txtmeslek.Text = " ";
            txtpersonelarama.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        public string Kullanıcı ;

        private void Form1_Load(object sender, EventArgs e)
        {

            LblKullaniciAd.Text = kullaniciAd;
            // sehirleri cekme:
            SqlCommand komut = new SqlCommand("select distinct ŞEHİR from Tbl_Personel  ",bgl.Baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbsehir.Items.Add(dr[0]);
            }
        }
        private void Listele()
        {
            SqlCommand Listele = new SqlCommand("select * from Tbl_Personel", bgl.Baglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

            Listele();
           
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand Kaydet = new SqlCommand("insert into Tbl_Personel (AD,SOYAD,ŞEHİR,MAAŞ,MEDENİ_HAL,MESLEK) values(@k1,@k2,@k3,@k4,@k5,@k6)",bgl.Baglanti());
            Kaydet.Parameters.AddWithValue("@k1",txtad.Text);
            Kaydet.Parameters.AddWithValue("@k2",txtsoyad.Text);
            Kaydet.Parameters.AddWithValue("@k3",cmbsehir.Text);
            Kaydet.Parameters.AddWithValue("@k4",mskmaas.Text);
            Kaydet.Parameters.AddWithValue("@k5",label10.Text);
            Kaydet.Parameters.AddWithValue("@k6",txtmeslek.Text);
            Kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Temizle();
            Listele();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label10.Text = "EVLİ";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label10.Text = "BEKAR";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Tası = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[Tası].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[Tası].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[Tası].Cells[2].Value.ToString();
            cmbsehir.Text = dataGridView1.Rows[Tası].Cells[3].Value.ToString();
            mskmaas.Text = dataGridView1.Rows[Tası].Cells[4].Value.ToString();
            label10.Text = dataGridView1.Rows[Tası].Cells[5].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[Tası].Cells[6].Value.ToString();

            if (label10.Text=="EVLİ")
            {
                radioButton1.Checked = true;
            }
            if (label10.Text=="BEKAR")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand KomutSil = new SqlCommand("Delete From Tbl_Personel where Id=@s1",bgl.Baglanti());
            KomutSil.Parameters.AddWithValue("@s1",txtid.Text);
            KomutSil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            
            MessageBox.Show("Kayıt Silindi !!!");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand KomutGüncelle = new SqlCommand("Update Tbl_Personel set AD=@g1,SOYAD=@g2,ŞEHİR=@g3,MAAŞ=@g4,MEDENİ_HAL=@g5,MESLEK=@g6 where ID=@g7 ",bgl.Baglanti());
            KomutGüncelle.Parameters.AddWithValue("@g1",txtad.Text);
            KomutGüncelle.Parameters.AddWithValue("@g2",txtsoyad.Text);
            KomutGüncelle.Parameters.AddWithValue("@g3",cmbsehir.Text);
            KomutGüncelle.Parameters.AddWithValue("@g4",mskmaas.Text);
            KomutGüncelle.Parameters.AddWithValue("@g5",label10.Text);
            KomutGüncelle.Parameters.AddWithValue("@g6",txtmeslek.Text);
            KomutGüncelle.Parameters.AddWithValue("@g7",txtid.Text);
            KomutGüncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi !!!");





        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
           
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik frm = new FrmGrafik();
            frm.Show();
        }

        private void btnrapor_Click(object sender, EventArgs e)
        {
            //FrmRapor frm = new FrmRapor();
            //frm.Show();
        }

        private void btnaraad_Click(object sender, EventArgs e)
        {
            SqlCommand komutAra = new SqlCommand(" select * from Tbl_Personel where AD=@p1",bgl.Baglanti());
            komutAra.Parameters.AddWithValue("@p1", txtpersonelarama.Text);
            SqlDataAdapter da = new SqlDataAdapter(komutAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnaraharf_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_PErsonel where AD like '%"+ txtpersonelarama.Text+"%'",bgl.Baglanti());
            SqlDataAdapter DataAdapter = new SqlDataAdapter(komut);
            DataTable Tablo = new DataTable();
            DataAdapter.Fill(Tablo);
            dataGridView1.DataSource=Tablo;
        }
    }
}
