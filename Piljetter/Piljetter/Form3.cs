using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piljetter
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string artist = artistLbl.Text;
            string scene = sceneTxt.Text;
            string country = countryTxt.Text;
            string city = cityTxt.Text;
            DateTime date = dateTimePicker1.Value;
        }
    }
}
