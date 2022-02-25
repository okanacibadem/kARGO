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
using UP.ORM;

namespace kARGO
{
    public partial class SevkForm : Form
    {
        public SevkForm()
        {
            InitializeComponent();
        }
        public void Goruntules()
        {
            dataGridView1.DataSource = SevkTableler.Listeles();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
          SevkTable uekle = new SevkTable();
            uekle.SevkiyatAdı = textBox2.Text;
            uekle.SevkAlınanNokta = textBox3.Text;
            uekle.SevkUlasılacakNokta = textBox4.Text;
            uekle.Mesafe = Convert.ToInt32(textBox5.Text);
            uekle.MesafeTutarı = Convert.ToInt32(textBox6.Text);
            uekle.AracId = Convert.ToInt32(textBox7.Text);
            if (SevkTableler.EkleS(uekle))
            {
                MessageBox.Show("başarıyla eklemndşr");
            }
            Goruntules();
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            SevkTable güncelle = new SevkTable();
            güncelle.SevkId = Convert.ToInt32(textBox1.Text);
            güncelle.SevkiyatAdı = textBox2.Text;
            güncelle.SevkAlınanNokta = textBox3.Text;
            güncelle.SevkUlasılacakNokta = textBox4.Text;
            güncelle.Mesafe = Convert.ToInt32(textBox5.Text);
            güncelle.MesafeTutarı = Convert.ToInt32(textBox6.Text);
            güncelle.AracId = Convert.ToInt32(textBox7.Text);
            if (SevkTableler.YenileS(güncelle))
            {
                MessageBox.Show("asdasf");
            }
            Goruntules();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Goruntules();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            SevkTable usil = new SevkTable();
            usil.SevkId = Convert.ToInt32(textBox1.Text);
            if (SevkTableler.SilS(usil))
            {

            }
            Goruntules();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["SevkId"].Value.ToString();
            textBox2.Text = satir.Cells["SevkiyatAdı"].Value.ToString();
            textBox3.Text = satir.Cells["SevkAlınanNokta"].Value.ToString();
            textBox4.Text = satir.Cells["Mesafe"].Value.ToString();
            textBox5.Text = satir.Cells["MesafeTutarı"].Value.ToString();
            textBox6.Text = satir.Cells["MesafeTutarı"].Value.ToString();
            textBox7.Text = satir.Cells["AracId"].Value.ToString();
        }
    }
}
