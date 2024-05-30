using Project_Akhir_PBO.controller;
using Project_Akhir_PBO.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Akhir_PBO
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            register_controller register = new register_controller();
            bool loggedIn = register.login(username, password);

            if (loggedIn)
            {
                menu menu = new menu();
                menu.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Akun tidak tersedia atau password salah!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        
    }
}
