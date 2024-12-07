using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon
{
    public partial class frmyenimusteri : Form
    {
        public frmyenimusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn101_Click(object sender, EventArgs e)
        {
            txtodano.Text = "101";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtodano.Text = "102";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtodano.Text = "103";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtodano.Text = "104";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtodano.Text = "105";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtodano.Text = "106";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtodano.Text = "107";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtodano.Text = "108";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtodano.Text = "109";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turuncu Renkli Butonlar Boş Odaları Gösterir");
        }

        private void dtpcikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih =Convert.ToDateTime(dtpgiris.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpcikis.Text);

            TimeSpan sonuc;
            sonuc = buyuktarih - kucuktarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret=Convert.ToInt32(label11.Text) * 50;
            txtucret.Text=ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle1 (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values (@Adi,@Soyadi,@Cinsiyet,@Telefon,@Mail,@TC,@OdaNo,@Ucret,@GirisTarihi,@CikisTarihi)", baglantı);
            komut.Parameters.AddWithValue("@Adi", txtad.Text);
            komut.Parameters.AddWithValue("@Soyadi", txtsoyad.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@Telefon", msktelefon.Text);
            komut.Parameters.AddWithValue("@Mail", txtmail.Text);
            komut.Parameters.AddWithValue("@TC", txttc.Text);
            komut.Parameters.AddWithValue("@OdaNo", txtodano.Text);
            komut.Parameters.AddWithValue("@Ucret", txtucret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", dtpgiris.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@CikisTarihi", dtpcikis.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }

        private void frmyenimusteri_Load(object sender, EventArgs e)
        {
            //oda101
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }

            //oda102
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }

            //oda103
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }

            //oda104
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }

            //oda105
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }

            //oda106
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }

            //oda107
            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }

            //oda108
            baglantı.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglantı);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn108.Enabled = false;
            }

            //oda109
            baglantı.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglantı);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false;
            }
        }
    }
}
//Data Source=BARANYıLMAZ\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True;Trust Server Certificate=True 
//'" + txtad.Text + "','" + txtsoyad.Text + "','" + comboBox1.Text + "','" + msktelefon.Text + "','" + txtmail.Text + "','" + txttc.Text + "','" + txtodano.Text + "','" + txtucret.Text + "','" + dtpgiris.Value.ToString("yyyy-MM-dd") + "','" + dtpcikis.Value.ToString("yyyy-MM-") + "'