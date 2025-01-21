using A2_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            List<Stock> items = StockDAL.GetEquipmentInfo();
            foreach (Stock item in items)
            {
                cmbStock.Items.Add(item.StockName);
                Stock.StockIds.Add(item.StockID, item);
                Stock.StockIDs.Add(item.StockName, item);

            }
            PopulateDataGrid();



        }

        private void PopulateDataGrid()
        {
            dataGridStockOrder.Rows.Clear();
            List<Stock> orders = new();
            try
            {
                orders = StockDAL.GetStockOrder(dtPickerOrderDate.Value.ToString("dd/MM/yyyy"));
                foreach (Stock item in orders)
                {
                    double cost = StockDAL.GetStockPrice(item.StockID);
                    dataGridStockOrder.Rows.Add(item.StockID.ToString(), Stock.StockIds[item.StockID].StockName.ToString(),
                        item.Quantity.ToString(), cost.ToString());

                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string date = dtPickerOrderDate.Value.ToString("dd/MM/yyyy");
                string item = cmbStock.Text;
                int quantity = Convert.ToInt32(cmbQuantity.Text);
                Stock newStock = new Stock();
                StockDAL.AddStockOrder(Stock.StockIDs[item].StockID, quantity, date);
                MessageBox.Show("Order Created");
                cmbStock.Text = "";
                cmbQuantity.Text = "";
                PopulateDataGrid();
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridStockOrder.SelectedRows[0].Cells[0].Value.ToString());

            StockDAL.DeleteStockOrder(id, orderDate);
        }
    }
}
