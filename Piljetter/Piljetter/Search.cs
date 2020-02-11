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
            //dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string artist = artistTxt.Text;
            string scene = sceneTxt.Text;
            string country = countryTxt.Text;
            string city = cityTxt.Text;
            ////DateTime date = dateTimePicker1.Value;

            List<ConcertsView> concerts = SearchEngine.SearchConcertsForCustomer(artist, scene, country, city);
            SearchResult frm4 = new SearchResult(CurrentCustomer, concerts);
            this.Hide();
            frm4.Show();
        }
    }
}
