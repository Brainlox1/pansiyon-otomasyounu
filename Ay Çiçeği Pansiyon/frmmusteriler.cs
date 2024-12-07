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
    public partial class frmmusteriler : Form
    {
        public frmmusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle1", baglantı);
            SqlDataReader oku= komut.ExecuteReader();
            
            while (oku.Read())
            {
                ListViewItem ekle= new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txttc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpgiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpcikis.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtodano.Text == "101")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "102")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "103")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "104")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "105")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105 ", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "106")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "107")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "108")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
            if (txtodano.Text == "109")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerigoster();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            comboBox1.Text = "";
            msktelefon.Clear();
            txtmail.Text = "";
            txttc.Clear();
            txtodano.Clear();
            txtucret.Clear();
            dtpgiris.Text = "";
            dtpcikis.Text = "";
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle1 set Adi='" + txtad.Text + "',Soyadi='" + txtsoyad.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + msktelefon.Text + "',Mail='"+txtmail.Text+ "',TC='"+txttc.Text+ "',OdaNo='"+txtodano.Text+ "',Ucret='"+txtucret.Text+ "' where Musteriid=" + id + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close() ;
            verilerigoster();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle1 where Adi like '%"+textBox1.Text+"%'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglantı.Close();
        }
    }
}
//SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");
//SqlCommand komut = new SqlCommand("delete from MusteriEkle1 where Musteriid=(" + id + ")", baglantı);
