using Project_Akhir_PBO.controller;
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
    public partial class ProdukCRUD : Form
    {
        public ProdukCRUD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_produk = textBox1.Text;
            int stock_produk;
            int size_produk;
            decimal harga;

            bool stokValid = int.TryParse(textBox2.Text, out stock_produk);
            bool sizeValid = int.TryParse(textBox3.Text, out size_produk);
            bool hargaValid = decimal.TryParse(textBox4.Text, out harga);

            if (stokValid && sizeValid && hargaValid)
            {
                ProdukControllers p1 = new ProdukControllers();
                p1.TambahProduk(nama_produk, stock_produk, size_produk, harga);

                MessageBox.Show("Produk berhasil ditambahkan.", "Sukses");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                if (!stokValid)
                {
                    MessageBox.Show("Stok produk harus berupa angka.");
                }
                if (!sizeValid)
                {
                    MessageBox.Show("Size produk harus berupa angka.");
                }
                if (!hargaValid)
                {
                    MessageBox.Show("Harga produk harus berupa angka desimal.");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
