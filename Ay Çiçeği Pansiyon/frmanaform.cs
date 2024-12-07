using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmadmingiris fr=new frmadmingiris();
            fr.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmyenimusteri fr=new frmyenimusteri();
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmodalar fr = new frmodalar();
            fr.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmmusteriler fr = new frmmusteriler();
            fr.Show();
            
        }

        private void btnhakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Pansiyon Kayıt UYgulaması / 2024 - Muş");
        }

        private void frmanaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            frmgelirgider fr= new frmgelirgider();
            fr.Show();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            frmstoklar fr= new frmstoklar();
            fr.Show();
        }

        private void btnradyo_Click(object sender, EventArgs e)
        {
            frmradyo fr= new frmradyo();
            fr.Show();
        }

        private void btngazeteler_Click(object sender, EventArgs e)
        {
            frmgazeteler fr= new frmgazeteler();
            fr.Show();
        }

        private void btnhavadurumu_Click(object sender, EventArgs e)
        {
            frmsifreguncelle fr= new frmsifreguncelle();
            fr.Show();
        }

        private void btnmusterimesaj_Click(object sender, EventArgs e)
        {
            frmmesajlar fr= new frmmesajlar();
            fr.Show();
        }
    }
}
