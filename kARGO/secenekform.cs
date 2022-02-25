using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kARGO
{
    public partial class secenekform : Form
    {
        public secenekform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracform git = new aracform();
            git.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musterilerform git = new Musterilerform();
            git.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SevkForm git = new SevkForm();
            git.Show();

        }
    }
}
