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
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");

        private void veriler() 
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglantı);
            SqlDataReader oku= komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle= new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }
            baglantı.Close();
        }

        private void veriler2() 
        {
            listView2.Items.Clear();
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektirik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);

            }
            baglantı.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,İcecek,Cerezler) values ('" + txtgidalar.Text + "','" + txticecekler.Text + "','" + txtatistirmaliklar.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close() ;
            veriler();

        }

        private void frmstoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnkaydet2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektirik,Su,İnternet) values ('" + txtelektirik.Text + "','" + txtsu.Text + "','" + txtinternet.Text + "')", baglantı);
            komut2.ExecuteNonQuery();
            baglantı.Close();
            veriler2();
        }
    }
}
