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
    public partial class Form2 : Form
    {
        public Customer CurrentCustomer { get; set; }
        
        public Form2(Customer c)
        {
            InitializeComponent();
            CurrentCustomer = c;
            Name.Text = $"Welcome {CurrentCustomer.Name}";
            Pesetas.Text = $"Current peseta balance: {CurrentCustomer.Pesetas}";
        }

        private void search_concertBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
