using Project_Akhir_PBO.Controllers;
using System;
using System.Windows.Forms;

namespace ProjectAkhirPBO.Views
{
    public partial class Buyer : Form
    {
        private BuyerController controller;

        public Buyer()
        {
            InitializeComponent();
            controller = new BuyerController();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = controller.GetAllBuyers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.AddBuyer(new Buyer
            {
                Nama = txtNama.Text,
                No_Telepon = txtNoTelepon.Text,
                Alamat = txtAlamat.Text
            });
            LoadData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            controller.UpdateBuyer(new Buyer
            {
                Id_Buyer = int.Parse(txtIdBuyer.Text),
                Nama = txtNama.Text,
                No_Telepon = txtNoTelepon.Text,
                Alamat = txtAlamat.Text
            });
            LoadData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            controller.DeleteBuyer(int.Parse(txtIdBuyer.Text));
            LoadData();
        }
    }
}
