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
    public partial class MyPage : Form
    {
        public Customer CurrentCustomer { get; set; }
        
        public MyPage(Customer c)
        {
            InitializeComponent();
            CurrentCustomer = c;
            Name.Text = $"Welcome {CurrentCustomer.Name}";
            Pesetas.Text = $"Current peseta balance: {CurrentCustomer.Pesetas}";
        }

        private void search_concertBtn_Click(object sender, EventArgs e)
        {
            Search frm3 = new Search(CurrentCustomer);
            this.Hide();
            frm3.Show();
        }

        private void Refill_pesetasBtn_Click(object sender, EventArgs e)
        {
            BuyPesetas buyPesetasForm = new BuyPesetas(CurrentCustomer);
            buyPesetasForm.Show();
            this.Close();

        }

        private void My_purchasesBtn_Click(object sender, EventArgs e)
        {
            var purchaseHistory = ClientHistoryHandler.GetCustomersPurchaseHistory(CurrentCustomer);
            PurchaseHistoryResults phr = new PurchaseHistoryResults(CurrentCustomer, purchaseHistory);
            phr.Show();
            this.Close();
        }

        private void My_CouponsBtn_Click(object sender, EventArgs e)
        {
            var coupons = ClientHistoryHandler.GetCustomersCouponRecords(CurrentCustomer);
            CouponRecord cr = new CouponRecord(CurrentCustomer, coupons);
            cr.Show();
            this.Close();
        }
    }
}
