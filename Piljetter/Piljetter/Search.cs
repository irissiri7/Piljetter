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
    public partial class Search : Form
    {
        public Customer CurrentCustomer { get; set; }

        public Search(Customer currentCustomer)
        {
            InitializeComponent();
            CurrentCustomer = currentCustomer;
            dateFrom.CustomFormat = "yyyy-mm-dd";
            dateTo.CustomFormat = "yyyy-mm-dd";
            dateFrom.MinDate = DateTime.Today;
            dateTo.MinDate = DateTime.Today;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string artist = artistTxt.Text;
            string scene = sceneTxt.Text;
            string country = countryTxt.Text;
            string city = cityTxt.Text;
            DateTime dFrom = dateFrom.Value;
            DateTime dTo = dateTo.Value;


            List<ConcertsView> concerts = SearchEngine.SearchConcertsForCustomer(artist, scene, country, city, dFrom, dTo);
            SearchResult frm4 = new SearchResult(CurrentCustomer, concerts);
            this.Hide();
            frm4.Show();
        }
    }
}
