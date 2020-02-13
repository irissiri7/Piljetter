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

namespace PiljettAdminGUI
{
    public partial class ConcertsOverview : Form
    {
        public ConcertsOverview()
        {
            InitializeComponent();
            List<ConcertsViewAdmin> commingConcerts = SearchEngine.SearchConcertsForAdmin(">");
            comingConcertsView.DataSource = commingConcerts;
        }

        private void cancelConcertBtn_Click(object sender, EventArgs e)
        {
            var concertId = Convert.ToString(comingConcertsView.CurrentRow.Cells[0].Value);
            bool giveCoupons = couponsCheckBox.Checked;
            var success = AdminEngine.CancelConcert(concertId, giveCoupons);
            if (success)
            {
                string message = "Concert deleted and ticket-money refunded";
                if (giveCoupons)
                {
                    message += " and coupons granted";
                }
                MessageBox.Show(message);
                AdminStartPage start = new AdminStartPage();
                this.Hide();
                start.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
