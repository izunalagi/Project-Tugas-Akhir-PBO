﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyerModels = Project_Akhir_PBO.models.Buyer;


namespace Project_Akhir_PBO.views
{
    public partial class BuyerUpdate2 : Form
    {
        public BuyerUpdate2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyerUpdate buyerUpdate = new BuyerUpdate();
            buyerUpdate.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void FillForm(BuyerModels buyer)
        {
            //// Mengisi nilai kontrol-kontrol pada form dengan data pembeli
            //textBox1.Text = buyer.Nama;
            //textBox2.Text = buyer.NoTelepon;
            //textBox3.Text = buyer.Alamat;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
