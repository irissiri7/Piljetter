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
            
        }

        private void addConcertBtn_Click(object sender, EventArgs e)
        {
            List<AvailableArtistsView> availableArtists = AdminEngine.GetAvailableArtists();
            List<AvailableScenesView> availableScenes = AdminEngine.GetAvailableScenes();
            AddConcert addConcertForm = new AddConcert(availableArtists, availableScenes);
            addConcertForm.Show();
            this.Hide();
        }

        private void concertsOverviewBtn_Click(object sender, EventArgs e)
        {
            ConcertsOverview overviewFrm = new ConcertsOverview();
            overviewFrm.Show();
            this.Hide();
            
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.Show();
            this.Hide();
        }
    }
}
