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

        private void TopArtistsBtn_Click(object sender, EventArgs e)
        {
            List<TopArtistView> topArtistList = AdminEngine.FindTopTenArtists(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            statisticsView.DataSource = topArtistList;
        }

        private void CancelledConcertsOverviewBtn_Click(object sender, EventArgs e)
        {
            List<ConcertsViewAdmin> cancelledConcerts = SearchEngine.SearchCancelledConcertsForAdmin();
            statisticsView.DataSource = cancelledConcerts;

        }

        private void CouponOvervBtn_Click(object sender, EventArgs e)
        {
            List<ClassLibrary.CouponInfoAdmin> coupons = AdminEngine.CouponOverview();
            statisticsView.DataSource = coupons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminStartPage start = new AdminStartPage();
            start.Show();
            this.Hide();
        }
    }
}
