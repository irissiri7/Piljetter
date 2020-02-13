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
    public partial class CouponRecord : Form
    {
        public Customer CurrentCustomer { get; set; }
        
        public CouponRecord(Customer customer, List<CouponInfoCustomer> listOfCoupons)
        {
            InitializeComponent();
            CurrentCustomer = customer;
            couponGridView.DataSource = listOfCoupons;
        }

        private void backToMyPageBtn_Click(object sender, EventArgs e)
        {
            MyPage myPage = new MyPage(CurrentCustomer);
            myPage.Show();
            this.Close();
        }
    }
}
