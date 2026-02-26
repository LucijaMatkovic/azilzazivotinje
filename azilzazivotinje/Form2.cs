using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azilzazivotinje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            string zapis = txtIme.Text + "|" + txtVrsta.Text + "|" + txtPasmina.Text + "|" + rbM.Checked + "|" + rbZ.Checked + "|" + numDob.Text + "|" + datum.Text + "|" + cbCije.Checked + "|" + cbKast.Checked + "|" + txtNapomena.Text + "|" + slika;
            Admin.Unos(zapis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = OpenFileDialog1.FileName;
            pictureBox1.Load(slika);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
