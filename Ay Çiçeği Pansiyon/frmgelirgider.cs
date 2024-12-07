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
    public partial class frmgelirgider : Form
    {
        public frmgelirgider()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel=Convert.ToInt32(txtpersonelsayi.Text);
            lblpersonelmaas.Text=(personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblkasatoplam.Text) - (Convert.ToInt16(lblpersonelmaas.Text) + Convert.ToInt16(lblalinanurunler1.Text) + Convert.ToInt16(lblalinanurunler2.Text) + Convert.ToInt16(lblalinanurunler3.Text) + Convert.ToInt16(lblfaturalar1.Text) + Convert.ToInt16(lblfaturalar2.Text) + Convert.ToInt16(lblfaturalar3.Text));
            lblsonuc.Text = sonuc.ToString();
        }

        private void frmgelirgider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle1", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkasatoplam.Text = oku["toplam"].ToString();
            }
            baglantı.Close();

            //Gıdalar
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblalinanurunler1.Text = oku2["toplam1"].ToString();
            }
            baglantı.Close();

            //İçecek
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İcecek) as toplam2 from Stoklar", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblalinanurunler2.Text = oku3["toplam2"].ToString();
            }
            baglantı.Close();

            //Cerezler
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblalinanurunler3.Text = oku4["toplam3"].ToString();
            }
            baglantı.Close();

            //elektirik
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektirik) as toplam4 from Faturalar", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblfaturalar1.Text = oku5["toplam4"].ToString();
            }
            baglantı.Close();

            //su
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblfaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglantı.Close();

            //İnternet
            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select sum(İnternet) as toplam6 from Faturalar", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblfaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglantı.Close();
        }
    }
}
