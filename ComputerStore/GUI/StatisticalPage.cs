using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class StatisticalPage : UserControl
    {
        public StatisticalPage()
        {
            InitializeComponent();
        }

        private void StatisticalPage_Load(object sender, EventArgs e)
        {
            // Load dgvProductsSold
            dgvProductsSold.DataSource = OrdersBLL.Instance.GetAll();

            // Load Chart
            chartTotalAmountOrders.DataSource = OrdersBLL.Instance.Statistical();
            chartTotalAmountOrders.Series["Tổng tiền"].XValueMember = "Month";
            chartTotalAmountOrders.Series["Tổng tiền"].YValueMembers = "Tổng tiền";

            //
            dgvReceipts.DataSource = ReceiptsBLL.Instance.GetAll();

            // Load Chart
            chartTotalAmountReceipts.DataSource = ReceiptsBLL.Instance.Statistical();
            chartTotalAmountReceipts.Series["Tổng tiền"].XValueMember = "Month";
            chartTotalAmountReceipts.Series["Tổng tiền"].YValueMembers = "Tổng tiền";
        }
    }
}
