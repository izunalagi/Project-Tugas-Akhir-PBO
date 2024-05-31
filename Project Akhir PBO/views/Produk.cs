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
    public partial class Produk : UserControl
    {
        private ProdukCRUD ProdukCRUD;
        public Produk()
        {
            InitializeComponent();
        }

        private void Produk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProdukCRUD == null || ProdukCRUD.IsDisposed)
            {
                ProdukCRUD = new ProdukCRUD();
                ProdukCRUD.Show();
            }
            else
            {
                ProdukCRUD.BringToFront();
            }
        }
        private void BuyerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProdukCRUD = null;
        }
    }
    
}
