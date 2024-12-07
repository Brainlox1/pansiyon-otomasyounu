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
    public partial class frmsifreguncelle : Form
    {
        public frmsifreguncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set kullanici='" + txtkullaniciadi.Text + "',sifre='" + txtsifre.Text + "' ", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
    }
}
