using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Project_Akhir_PBO.controllers;
using Project_Akhir_PBO.models;
using Project_Akhir_PBO.views;

namespace Project_Akhir_PBO
{
    public partial class Buyer : UserControl
    {
        private BuyerController buyerController; 
        private BuyerCRUD BuyerCRUD;
        private BuyerUpdate BuyerUpdate;
       
       


        public Buyer()
        {
            InitializeComponent();
            buyerController = new BuyerController();
            LoadBuyersToDataGridView();
        }

        private void tabelBuyer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoTelepon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BuyerCRUD == null || BuyerCRUD.IsDisposed)
            {
                BuyerCRUD = new BuyerCRUD();
                BuyerCRUD.Show();
            }
            else
            {
                BuyerCRUD.BringToFront();
            }
        }
        private void BuyerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BuyerCRUD = null;
        }

        private void BuyerCRUD_Load(object sender, EventArgs e)
        {
            
        }

        private void Buyer_Load(object sender, EventArgs e)
        {

        }
        private void LoadBuyersToDataGridView()
        {
            var buyers = buyerController.GetAllBuyers();
            dataGridView1.DataSource = buyers;
        }

       
        private void Form_Load(object sender, EventArgs e)
        {
            LoadBuyersToDataGridView();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if(BuyerUpdate == null || BuyerUpdate.IsDisposed)
            {
                BuyerUpdate = new BuyerUpdate();
                BuyerUpdate.Show();
            }
            else
            {
                BuyerUpdate.BringToFront();
            }
        }
        private void BuyerUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            BuyerUpdate = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadBuyersToDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
