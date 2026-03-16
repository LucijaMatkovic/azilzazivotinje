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
            string slika = openFileDialog1.FileName;
            string spol;
            string kast = "";
            string cije = "";
            if (cbKast.Checked == true)
            {
                kast = "Kastriran";
            }
            else {
                kast = "Nije kastriran";
            }
            if (cbCije.Checked == true)
            {
               cije = "Cijepljen";
            }
            else
            {
                cije = "Nije cijepljen";
            }
            if (rbM.Checked == true)
            {
                spol = "Muško";
            }
            else if (rbZ.Checked == true)
            {
                spol = "Žensko";
            }
            string zapis = txtIme.Text + "|" + txtVrsta.Text + "|" + txtPasmina.Text + "|" + rbM.Checked + "|" + rbZ.Checked + "|" + numDob.Text + "|" + datum.Text + "|" + cbCije.Checked + "|" + cbKast.Checked + "|" + txtNapomena.Text + "|" + slika;
            Admin.Unos(zapis);
            txtIme.Clear();
            txtVrsta.Clear();
            txtPasmina.Clear();
            rbM.Checked = false;
            rbZ.Checked = false;
            numDob.Value = 0;
            datum.Value = DateTime.Now;
            cbCije.Checked = false;
            cbKast.Checked = false;
            txtNapomena.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            pictureBox1.Load(slika);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

