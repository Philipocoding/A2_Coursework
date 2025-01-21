using A2_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Coursework
{
    public partial class OrderStock : Form
    {
        public OrderStock()
        {
            InitializeComponent();
        }

        private void OrderStock_Load(object sender, EventArgs e)
        {
            List<Stock> items = StockDAL.GetEquipmentInfo();// dtPickerOrderDate.Value.ToString("d/MM/yyyy"));
            foreach (Stock item in items)
                cmbStock.Items.Add(item.StockName);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string date = dtPickerOrderDate.Value.ToString();
            string item = cmbStock.Text;
            int quantity = Convert.ToInt32(cmbQuantity.Text);
            Stock newStock = new Stock(item,quantity);
            //StockDAL.GetStockOrder(date);
        }


    }
}
