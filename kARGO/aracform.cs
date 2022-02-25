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
using UP.ORM.Entity;
using UP.ORM.Facede;


namespace kARGO
{
    public partial class aracform : Form
    {
        public void Goruntule()
        {
            dataGridView1.DataSource = Araclar.Listele();
        }
        public aracform()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac uekle = new Arac();
            uekle.AracTuru = textBox2.Text;
            uekle.AracKapasitesi = Convert.ToInt32(textBox3.Text);
            uekle.AracSoförü = textBox4.Text;
            if (Araclar.Ekle(uekle))
            {
                MessageBox.Show("başarıyla eklemndşr");
            }
            Goruntule();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Arac usil = new Arac();
            usil.AracId = Convert.ToInt32(textBox1.Text);
            if (Araclar.Sil(usil))
            {

            }
            Goruntule();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Arac güncelle = new Arac();
            güncelle.AracId = Convert.ToInt32(textBox1.Text);
            güncelle.AracTuru = textBox2.Text;
            güncelle.AracKapasitesi = Convert.ToInt32(textBox3.Text);
            güncelle.AracSoförü = textBox4.Text;
            if (Araclar.Yenile(güncelle))
            {
                MessageBox.Show("asdasf");
            }
            Goruntule();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["AracId"].Value.ToString();
            textBox2.Text = satir.Cells["AracTuru"].Value.ToString();
            textBox3.Text = satir.Cells["AracKapasitesi"].Value.ToString();
            textBox4.Text = satir.Cells["AracSoförü"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
