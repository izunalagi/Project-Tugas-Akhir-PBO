using Project_Akhir_PBO.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Akhir_PBO.views
{
    public partial class BuyerCRUD : Form
    {
        public BuyerCRUD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string noTelepon = textBox3.Text;
            string alamat = textBox2.Text;

            BuyerController b1 = new BuyerController();
            b1.TambahBuyer(nama, noTelepon, alamat);

            MessageBox.Show("Buyer berhasil ditambahkan.", "Sukses");

            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyerCRUD_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
