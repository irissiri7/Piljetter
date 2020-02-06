using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Piljetter
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text;
            string password = Passwordtxt.Text;

            if(name.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter name and password");
            }
            else
            {
                List<Customer> customer = SignInHandler.SignIn(name, password);
                if(customer.Count == 0)
                {
                    MessageBox.Show("Could not find user");
                }
                else
                {
                    MessageBox.Show($"Welcome{customer[0].Name}");
                }
            }

        }
    }
}
