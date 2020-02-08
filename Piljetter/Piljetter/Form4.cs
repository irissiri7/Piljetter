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
    public partial class Form4 : Form
    {
        public Customer CurrentCustomer { get; set; }

        public Form4(Customer currentCustomer, List<SearchResultConcerts> concerts)
        {
            InitializeComponent();
            CurrentCustomer = currentCustomer;
            searchResultTable.DataSource = concerts;
        }

        private void BackToMyPageBtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(CurrentCustomer);
            this.Hide();
            frm2.Show();
        }

        private void BuyTicketBtn_Click(object sender, EventArgs e)
        {
            var tickets = Convert.ToInt32(Math.Round(numTickets.Value, 0));
            var concert = Convert.ToInt32(Math.Round(concertId.Value, 0));

            bool success = TicketVendingMachine.BuyTickets(CurrentCustomer, tickets, concert);
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
