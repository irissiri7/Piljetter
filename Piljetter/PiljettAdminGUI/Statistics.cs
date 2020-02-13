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
using ClassLibraryReborn.POCOS;

namespace PiljettAdminGUI
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            dateTimePickerFrom.CustomFormat = "yyy-mm-dd";
            dateTimePickerTo.CustomFormat = "yyy-mm-dd";
        }

        private void topArtistsBtn_Click(object sender, EventArgs e)
        {
            List<TopArtistView> topArtistList = AdminEngine.FindTopTenArtists(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            statisticsView.DataSource = topArtistList;
        }

        private void passedConcertsOverviewBtn_Click(object sender, EventArgs e)
        {
            List<ConcertsViewAdmin> passedConcerts = SearchEngine.SearchConcertsForAdmin("<");
            statisticsView.DataSource = passedConcerts;

        }
    }
}
