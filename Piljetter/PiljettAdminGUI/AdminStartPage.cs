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
    public partial class AdminStartPage : Form
    {
        public AdminStartPage()
        {
            InitializeComponent();
            List<ConcertsViewAdmin> commingConcerts = SearchEngine.SearchConcertsForAdmin(">");
            comingConcertsView.DataSource = commingConcerts;
        }

        private void addConcertBtn_Click(object sender, EventArgs e)
        {
            List<AvailableArtistsView> availableArtists = AdminEngine.GetAvailableArtists();
            List<AvailableScenesView> availableScenes = AdminEngine.GetAvailableScenes();
            AddConcert addConcertForm = new AddConcert(availableArtists, availableScenes);
            addConcertForm.Show();
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var concertId = Convert.ToString(comingConcertsView.CurrentRow.Cells[0].Value);
            bool giveCoupons = checkBoxCoupons.Checked;
            var success = AdminEngine.CancelConcert(concertId, giveCoupons);
            if (success)
            {
                MessageBox.Show("Concert deleted and ticket-money refunded");
                AdminStartPage start = new AdminStartPage();
                this.Hide();
                start.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
