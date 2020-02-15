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
    public partial class BuyPesetas : Form
    {
        public Customer CurrentCustomer { get; set; }
        
        public BuyPesetas(Customer customer)
        {
            InitializeComponent();
            CurrentCustomer = customer;
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            var pesetasAmount = Convert.ToInt32(Math.Round(numOfPesetasUpDown.Value, 0));
            var success = VendingMachine.BuyPesetas(CurrentCustomer, pesetasAmount);
            if (success)
            {
                MessageBox.Show("Pesetas refilled!");
                //Here i must "sign in" (aka "refresh") the customer again to get the updated information from the Db.
                CurrentCustomer = CustomerEngine.SignIn(CurrentCustomer.Name, CurrentCustomer.Password)[0];
                MyPage myPage = new MyPage(CurrentCustomer);
                myPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hmm, something went wrong...");
                MyPage myPage = new MyPage(CurrentCustomer);
                myPage.Show();
                this.Hide();
            }
            

        }

        private void backToMyPageBtn_Click(object sender, EventArgs e)
        {
            MyPage myPage = new MyPage(CurrentCustomer);
            myPage.Show();
            this.Close();
        }
    }
}
