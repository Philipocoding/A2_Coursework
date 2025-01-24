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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                if (!Stock.StockIds.ContainsKey(item.StockID))
                {
                    Stock.StockIds.Add(item.StockID, item);

                }

                if (!Stock.StockIDs.ContainsKey(item.StockName))
                {
                    Stock.StockIDs.Add(item.StockName, item);

                }

            }
            PopulateCustomDataGrid();



        }

        private void PopulateDataGridByDate()
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
                        item.Quantity.ToString(), item.OrderDate.ToString(), cost.ToString());

                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateDataGridAllOrders()
        {
            dataGridStockOrder.Rows.Clear();
            List<Stock> orders = new();
            try
            {
                orders = StockDAL.GetAllOrders();
                foreach (Stock item in orders)
                {
                    double cost = StockDAL.GetStockPrice(item.StockID);
                    dataGridStockOrder.Rows.Add(item.StockID.ToString(), Stock.StockIds[item.StockID].StockName.ToString(),
                        item.Quantity.ToString(), item.OrderDate.ToString(), cost.ToString());

                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateCustomDataGrid()
        {
            DateTime today = DateTime.Now.AddDays(-1);


            dataGridStockOrder.Rows.Clear();
            try
            {
                List<Stock> allorders = StockDAL.GetAllOrders();
                foreach (Stock item in allorders)
                {
                    DateTime itemDate = DateTime.Parse(item.OrderDate);
                    if (itemDate >= today)
                    {
                        double cost = StockDAL.GetStockPrice(item.StockID);
                        dataGridStockOrder.Rows.Add(item.StockID.ToString(), Stock.StockIds[item.StockID].StockName.ToString(),
                            item.Quantity.ToString(), itemDate.ToString("dd/MM/yyyy"), cost.ToString());
                    }


                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            

            try
            {
                string date = dtPickerOrderDate.Value.ToString("dd/MM/yyyy");
                string item = cmbStock.Text;
                int quantity = Convert.ToInt32(cmbQuantity.Text);

                if (btnOrder.Text == "Save changes")
                {
                    StockDAL.DeleteStockOrder(Stock.StockIDs[cmbStock.Text].StockID,
                        date);
                    StockDAL.AddStockOrder(Stock.StockIDs[cmbStock.Text].StockID, quantity,
                        date);
                    btnOrder.Text = "Order";
                    MessageBox.Show("Order updated");
                    cmbStock.Text = "";
                    cmbQuantity.Text = "";
                    PopulateCustomDataGrid();
                }
                else
                {
                    DateTime itemDate = DateTime.Parse(date);
                    if (itemDate >= today)
                    {
                        Stock newStock = new Stock();
                        StockDAL.AddStockOrder(Stock.StockIDs[item].StockID, quantity, date);
                        MessageBox.Show("Order Created");
                        cmbStock.Text = "";
                        cmbQuantity.Text = "";
                        PopulateCustomDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Not a valid date!");
                    }
                    
                }

            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridStockOrder.SelectedRows.Count < 1)
                {
                    throw new CustomException("Error: No row selected");
                }
                int id = Convert.ToInt32(dataGridStockOrder.SelectedRows[0].Cells[0].Value.ToString());
                string orderDate = dataGridStockOrder.SelectedRows[0].Cells[3].Value.ToString();
                StockDAL.DeleteStockOrder(id, orderDate);
                PopulateCustomDataGrid();
                MessageBox.Show("Order deleted!");

            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            PopulateCustomDataGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cmbStock.Text = dataGridStockOrder.SelectedRows[0].Cells[1].Value.ToString();
                cmbQuantity.Text = dataGridStockOrder.SelectedRows[0].Cells[2].Value.ToString();
                dtPickerOrderDate.Text = dataGridStockOrder.SelectedRows[0].Cells[3].Value.ToString();
                btnOrder.Text = "Save changes";
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Select a row!");
            }



        }

        private void dataGridStockOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cmbStock.Text = dataGridStockOrder.SelectedRows[0].Cells[1].Value.ToString();
            //cmbQuantity.Text = dataGridStockOrder.SelectedRows[0].Cells[2].Value.ToString();
            //dtPickerOrderDate.Text = dataGridStockOrder.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnViewAllOrders_Click(object sender, EventArgs e)
        {
            PopulateDataGridAllOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateDataGridByDate();
        }
    }
}
