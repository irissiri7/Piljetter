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
    public partial class PurchaseHistoryResults : Form
    {
        public Customer CurrentCustomer { get; set; }
        public PurchaseHistoryResults(Customer customer, List<PurchaseHistory>purchasehistorylist)
        {
            InitializeComponent();
            CurrentCustomer = customer;
            PurchaseHistoryGrid.DataSource = purchasehistorylist;
        }

        private void backToMypageBtn_Click(object sender, EventArgs e)
        {
            MyPage myPage = new MyPage(CurrentCustomer);
            myPage.Show();
            this.Close();
        }
    }
}
