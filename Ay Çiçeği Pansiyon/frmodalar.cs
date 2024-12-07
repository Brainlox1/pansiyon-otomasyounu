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
    public partial class frmodalar : Form
    {
        public frmodalar()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");

        private void frmodalar_Load(object sender, EventArgs e)
        {
            //oda101
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() +" "+ oku1["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btn101.Text != "101") 
            {
                btn101.BackColor = Color.Red;
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
            }
        }
    }
}
