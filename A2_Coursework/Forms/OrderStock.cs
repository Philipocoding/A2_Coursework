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
        void StyleDatagridview()
        {
            foreach (DataGridViewColumn col in dataGridStockOrder.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridStockOrder.BorderStyle = BorderStyle.Fixed3D;
            dataGridStockOrder.BackgroundColor = Color.White;
            dataGridStockOrder.GridColor = Color.LightGray;
            dataGridStockOrder.EnableHeadersVisualStyles = false;
            dataGridStockOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridStockOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridStockOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridStockOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dataGridStockOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridStockOrder.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            dataGridStockOrder.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridStockOrder.DefaultCellStyle.BackColor = Color.White;
            dataGridStockOrder.DefaultCellStyle.ForeColor = Color.Black;
            dataGridStockOrder.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridStockOrder.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridStockOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dataGridStockOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridStockOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridStockOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStockOrder.RowHeadersVisible = true;
            dataGridStockOrder.RowHeadersWidth = 30;
        }
        public static void populateDictionary()
        {
            List<Stock> items = StockDAL.GetEquipmentInfo();
            foreach (Stock item in items)
            {
                //cmbStock.Items.Add(item.StockName);
                if (!Stock.StockIds.ContainsKey(item.StockID))
                {
                    Stock.StockIds.Add(item.StockID, item);
                }

                if (!Stock.StockIDs.ContainsKey(item.StockName))
                {
                    Stock.StockIDs.Add(item.StockName, item);
                }

            }
        }
        private void OrderStock_Load(object sender, EventArgs e)
        {

            lblOrderStock.Text = "";

            populateDictionary();
            foreach (KeyValuePair<string, Stock> item in Stock.StockIDs)
            {
                cmbStock.Items.Add(item.Value.StockName);
            }
            StyleDatagridview();
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
            PopulateDataGridAllOrders();



        }

        private void PopulateDataGridByDate(string date)
        {
            dataGridStockOrder.Rows.Clear();
            List<Stock> orders = new();
            try
            {
                orders = StockDAL.GetStockOrder(date);
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
            int counter = 0;

            dataGridStockOrder.Rows.Clear();
            try
            {
                List<Stock> allorders = StockDAL.GetAllOrders();
                if (allorders.Count > 0)
                {
                    foreach (Stock item in allorders)
                    {
                        DateTime itemDate = DateTime.Parse(item.OrderDate);
                        if (item.OrderReceived == 0)
                        {
                            double cost = StockDAL.GetStockPrice(item.StockID);
                            dataGridStockOrder.Rows.Add(item.StockID.ToString(), Stock.StockIds[item.StockID].StockName.ToString(),
                                item.Quantity.ToString(), itemDate.ToString("dd/MM/yyyy"), cost.ToString());
                        }
                        else { counter = counter + 1; }
                    }
                    if (counter == allorders.Count)
                    {
                        throw new CustomException("No pending orders!");

                    }
                }
                else
                {
                    throw new CustomException("No pending orders!");

                }

            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.AddDays(3);

            try
            {
                string date = dtPickerOrderDate.Value.ToString("dd/MM/yyyy");
                string item = cmbStock.Text;
                int quantity = Convert.ToInt32(cmbQuantity.Text);

                if (quantity < 1)
                {
                    throw new CustomException("Invalid quantity");
                }

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
                    MessageBox.Show("A delivery will take at least 3 days to arrive!");
                }



            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;

            try
            {
                if (dataGridStockOrder.SelectedRows[0].Cells[0].Value is null)
                {
                    throw new CustomException("Select a record with data!");
                }
                else
                {
                    int id = Convert.ToInt32(dataGridStockOrder.SelectedRows[0].Cells[0].Value.ToString());
                    string orderDate = dataGridStockOrder.SelectedRows[0].Cells[3].Value.ToString();
                    StockDAL.DeleteStockOrder(id, orderDate);
                    PopulateDataGridAllOrders();
                    MessageBox.Show("Order deleted!");
                }
                    

            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;

            PopulateCustomDataGrid();
            pnlDateFilter.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pnlEdit.Visible)
            {
                lblOrderStock.Text = "";

                pnlEdit.Visible = false;
            }
            else
            {
                lblOrderStock.Text = "Edit order";
                pnlEdit.Visible = true;
            }
            try
            {
                if (dataGridStockOrder.SelectedRows[0].Cells[0].Value is null)
                {
                    pnlEdit.Visible = false;

                    throw new CustomException("Select a record with data!");
                }
                else
                {
                    //pnlEdit.Visible = true;
                    cmbStockEdit.Text = dataGridStockOrder.SelectedRows[0].Cells[1].Value.ToString();
                    cmbQtyEdit.Text = dataGridStockOrder.SelectedRows[0].Cells[2].Value.ToString();
                    cmbDTEdit.Text = dataGridStockOrder.SelectedRows[0].Cells[3].Value.ToString();
                }


            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Select a row!");
            }



        }

        private void dataGridStockOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridStockOrder.SelectedRows.Count > 0)
                {
                    if (dataGridStockOrder.SelectedRows[0].Cells[0].Value is null)
                    {
                        throw new CustomException("Select a record with data!");
                    }
                    else
                    {
                        cmbStockEdit.Text = dataGridStockOrder.SelectedRows[0].Cells[1].Value.ToString();
                        cmbQtyEdit.Text = dataGridStockOrder.SelectedRows[0].Cells[2].Value.ToString();
                        cmbDTEdit.Text = dataGridStockOrder.SelectedRows[0].Cells[3].Value.ToString();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Select a record");
                }

            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Select a row!");
            }
        }

        private void btnViewAllOrders_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;

            PopulateDataGridAllOrders();
        }



        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            StockDAL.DeleteStockOrder(Stock.StockIDs[cmbStockEdit.Text].StockID,
                        cmbDTEdit.Value.ToString("dd/MM/yyyy"));
            StockDAL.AddStockOrder(Stock.StockIDs[cmbStockEdit.Text].StockID, Convert.ToInt32(cmbQtyEdit.Text),
                 cmbDTEdit.Value.ToString("dd/MM/yyyy"));
            btnOrder.Text = "Order";
            MessageBox.Show("Order updated");
            cmbStock.Text = "";
            cmbQuantity.Text = "";
            cmbQtyEdit.Text = "";
            cmbStockEdit.Text = "";
            PopulateDataGridAllOrders();
            pnlEdit.Visible = false;


        }

        private void btnMarkasReceived_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;

            try
            {
                if (dataGridStockOrder.SelectedRows.Count < 1)
                {
                    throw new CustomException("Error: No row selected");
                }
                else
                {
                    int id = Convert.ToInt32(dataGridStockOrder.SelectedRows[0].Cells[0].Value);
                    int quantity = Convert.ToInt32(dataGridStockOrder.SelectedRows[0].Cells[2].Value);
                    StockDAL.AddStock(id, quantity);

                    int ID = Convert.ToInt32(dataGridStockOrder.SelectedRows[0].Cells[0].Value);
                    string date = dataGridStockOrder.SelectedRows[0].Cells[3].Value.ToString();
                    StockDAL.MarkOrderAsReceived(ID,date);
                    PopulateDataGridAllOrders();
                    MessageBox.Show("Order received!");

                }

            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(System.NullReferenceException ex)
            {
                MessageBox.Show("An error occurred");
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOrderStock.Text = "";
            pnlEdit.Visible = false;
        }

        private void pnlStockReorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewOrders_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFIlterByDate_Click(object sender, EventArgs e)
        {
            PopulateDataGridByDate(dtPickerFilter.Value.ToString("dd/MM/yyyy"));
            pnlDateFilter.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopulateCustomDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;

           if(pnlDateFilter.Visible)
            {
                pnlDateFilter.Visible = false;
            }
            else
            {
                pnlDateFilter.Visible = true;
                pnlDateFilter.BringToFront();


            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateDataGridAllOrders();
            pnlDateFilter.Visible = false;
        }
    }
}
