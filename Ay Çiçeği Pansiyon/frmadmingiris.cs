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
    public partial class frmadmingiris : Form
    {
        public frmadmingiris()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=BARANYıLMAZ\\SQLEXPRESS;Initial Catalog=Aycicegipansiyon;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            try 
            {
                baglantı.Open();
                string sql = "select * from AdminGiris where kullanici=@kullaniciadi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi",txtkullaniciadi.Text);
                SqlParameter prm2 = new SqlParameter("sifresi", txtsifre.Text);
                SqlCommand komut = new SqlCommand(sql, baglantı);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0) 
                {
                    frmanaform fr = new frmanaform();
                    fr.ShowDialog();
                }
                }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
