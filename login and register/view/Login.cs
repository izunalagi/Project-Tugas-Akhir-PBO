using login_and_register.controller;
using login_and_register.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_and_register
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Register register = new Register();
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
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                
                }
                else
                {
                    MessageBox.Show("Akun tidak tersedia atau password salah!");
                }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
