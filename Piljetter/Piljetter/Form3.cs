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
    public partial class Form3 : Form
    {
        public Customer CurrentCustomer { get; set; }

        public Form3(Customer currentCustomer)
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

            List<SearchResultConcerts> concerts = SearchEngine.SearchConcerts(artist, scene, country, city);
            Form4 frm4 = new Form4(CurrentCustomer, concerts);
            this.Hide();
            frm4.Show();
        }
    }
}
