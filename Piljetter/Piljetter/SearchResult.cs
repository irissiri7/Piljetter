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
    public partial class SearchResult : Form
    {
        public Customer CurrentCustomer { get; set; }

        public SearchResult(Customer currentCustomer, List<ConcertsView> concerts)
        {
            InitializeComponent();
            CurrentCustomer = currentCustomer;
            searchResultView.DataSource = concerts;
        }

        private void BackToMyPageBtn_Click(object sender, EventArgs e)
        {
            MyPage frm2 = new MyPage(CurrentCustomer);
            this.Hide();
            frm2.Show();
        }

        private void BuyTicketBtn_Click(object sender, EventArgs e)
        {
            var tickets = Convert.ToInt32(Math.Round(numTickets.Value, 0));
            var concert = Convert.ToInt32(searchResultView.CurrentRow.Cells[0].Value);
            var useCoupons = useCouponBox.Checked;

            bool success = VendingMachine.BuyTickets(CurrentCustomer, tickets, concert, useCoupons);
            CurrentCustomer = CustomerHandler.SignIn(CurrentCustomer.Name, CurrentCustomer.Password)[0];
            if (success)
            {
                MessageBox.Show("Tickets bought!");
            }
            else
            {
                MessageBox.Show("Oh, something went wrong...");
            }
        }

        
    }
}
