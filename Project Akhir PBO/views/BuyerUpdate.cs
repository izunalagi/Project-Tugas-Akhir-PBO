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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BuyerModels = Project_Akhir_PBO.models.Buyer;


namespace Project_Akhir_PBO.views
{
    public partial class BuyerUpdate : Form
    {
        public BuyerUpdate2 BuyerUpdate2;
     
        public BuyerUpdate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(textBox1.Text);

          
            //BuyerController buyerController = new BuyerController();
            //Buyer buyer = buyerController.UpdateBuyer(id);


            //if (buyer != null)
            //{
                
            //    if (BuyerUpdate2 == null || BuyerUpdate2.IsDisposed)
            //    {
            //        BuyerUpdate2 = new BuyerUpdate2();
            //        BuyerUpdate2.FillForm(buyer); 
            //        BuyerUpdate2.Show();
            //    }
            //    else
            //    {
            //        BuyerUpdate2.BringToFront();
            //    }
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Pembeli dengan ID tersebut tidak ditemukan.");
            //}
        }

    

        private void BuyerUpdate2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BuyerUpdate2 = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
