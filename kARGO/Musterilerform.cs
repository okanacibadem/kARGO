using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using UP.ORM.Entity;
using UP.ORM.Facede;
using UP.ORM;

namespace kARGO
{
    public partial class Musterilerform : Form
    {
        public Musterilerform()
        {
            InitializeComponent();
        }
        public void Goruntulem()
        {
            dataGridView1.DataSource = MusteriTableler.ListeleM();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriTable uekle = new MusteriTable();
            uekle.MusteriAdsoyad = textBox2.Text;
            uekle.Adres = textBox3.Text;
            uekle.Telefon = textBox4.Text;
            uekle.Mail = textBox5.Text;
            uekle.ÖdemeDurumu = textBox6.Text;
            uekle.SevkıyatId = Convert.ToInt32(textBox7.Text);

            if (MusteriTableler.EkleM(uekle))
            {
                MessageBox.Show("başarıyla eklemndşr");
            }
            Goruntulem();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Goruntulem();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriTable usil = new MusteriTable();
            usil.MusteriId = Convert.ToInt32(textBox1.Text);
            if (MusteriTableler.SilM(usil))
            {

            }
            Goruntulem();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["MusteriId"].Value.ToString();
            textBox2.Text = satir.Cells["MusteriAdsoyad"].Value.ToString();
            textBox3.Text = satir.Cells["Adres"].Value.ToString();
            textBox4.Text = satir.Cells["Telefon"].Value.ToString();
            textBox5.Text = satir.Cells["Mail"].Value.ToString();
            textBox6.Text = satir.Cells["ÖdemeDurumu"].Value.ToString();
            textBox6.Text = satir.Cells["SevkıyatId"].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

            MusteriTable güncelle = new MusteriTable();
            güncelle.MusteriId = Convert.ToInt32(textBox1.Text);
            güncelle.MusteriAdsoyad = textBox2.Text;
            güncelle.Adres = textBox3.Text;
            güncelle.Telefon = textBox4.Text;
            güncelle.Mail = textBox4.Text;
            güncelle.ÖdemeDurumu = textBox5.Text;
            güncelle.SevkıyatId =Convert.ToInt32(textBox6.Text);
            if (MusteriTableler.YenileM(güncelle))
            {
                MessageBox.Show("asdasf");
            }
            Goruntulem();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
