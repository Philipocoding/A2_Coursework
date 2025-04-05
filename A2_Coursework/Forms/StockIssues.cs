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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A2_Coursework
{
    public partial class StockIssues : Form
    {
        public StockIssues()
        {
            InitializeComponent();
        }

        private MainMenu _mainMenu;

        public StockIssues(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
        }

        void StyleDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = true;
            dgv.RowHeadersWidth = 30;
        }

        void ApplyStyles()
        {
            StyleDataGridView(DataGridStockIssues);
        }
        private void ViewStockLevels_Load(object sender, EventArgs e)
        {
            ApplyStyles();
            cmbStockIssue.Items.Clear();
            List<Stock> items = StockDAL.GetEquipmentInfo();


            foreach (Stock item in items)
            {
                cmbStockIssue.Items.Add(Stock.StockIds[item.StockID].StockName.ToString());
                if (!Stock.StockIds.ContainsKey(item.StockID))
                {
                    Stock.StockIds.Add(item.StockID, item);

                }

                if (!Stock.StockIDs.ContainsKey(item.StockName))
                {
                    Stock.StockIDs.Add(item.StockName, item);

                }

            }
            populateDataGrids();
        }

        private void PopulatePendingIssues()
        {
            int counter = 0;

            DataGridStockIssues.Rows.Clear();
            try
            {
                List<Stock> Issues = Stock.RetrieveStockIssues();
                if (Issues.Count > 0)
                {
                    foreach (Stock item in Issues)
                    {
                        DateTime itemDate = DateTime.Parse(item.SolutionDate);
                        if (item.IssueResolved == 0)
                        {
                            double cost = StockDAL.GetStockPrice(item.StockID);
                            DataGridStockIssues.Rows.Add(item.StockID.ToString(), Stock.StockIds[item.StockID].StockName.ToString(),
                                item.Quantity.ToString(), Stock.GetIssueID(Convert.ToInt32(item.IssueID)).ToString(), itemDate.ToString("dd/MM/yyyy"));
                        }
                        else { counter = counter + 1; }
                    }
                    if (counter == Issues.Count)
                    {
                        throw new CustomException("No pending issues!");

                    }
                }
                else
                {
                    throw new CustomException("No pending issues!");

                }

            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populateDataGrids()
        {

           
            DataGridStockIssues.Rows.Clear();
            foreach (Stock item in Stock.RetrieveStockIssues())
            {
                DataGridStockIssues.Rows.Add(item.StockID.ToString(), item.StockName,
                    item.Quantity.ToString(), Stock.GetIssueID(Convert.ToInt32(item.IssueID)).ToString(), item.SolutionDate);

            }
        }

        

        



        private void button2_Click(object sender, EventArgs e)
        {
            if (pnlReportIssue.Visible)
            {
                pnlReportIssue.Visible = false;
            }
            else
            {
                pnlReportIssue.Visible = true;
            }
        }

        private void btnConfirmIssue_Click(object sender, EventArgs e)
        {
            try
            {
                int stockID = Stock.StockIDs[cmbStockIssue.Text].StockID;
                int quantity = Convert.ToInt32(cmbQuantityIssue.Text);
                string solutionDate = dtPickerSolutionDate.Value.ToString("dd/MM/yyyy");

                if ((quantity < 1)||(quantity > 15))
                {
                    throw new CustomException("Not a valid quantity");
                }
                if (DateTime.Now.AddDays(2) < dtPickerSolutionDate.Value)
                {
                    StockDAL.StockIssue(stockID, quantity, Stock.GetIssueID(cmbIsueDescription.Text), solutionDate);
                    MessageBox.Show("Issue reported!");
                    populateDataGrids();
                    pnlReportIssue.Visible = false;
                }
                else
                {
                    MessageBox.Show("It takes a minimum of 2 days to resolve issues");
                }

            }
            catch (CustomException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException ex)
            {
                MessageBox.Show("Not a valid stock item");
            }
            catch (System.FormatException ex)
            {

                MessageBox.Show("Invalid data entered!");
            }
        }

        private void STockIssueResolved_Click(object sender, EventArgs e)
        {
            try
            {
                if ((DataGridStockIssues.SelectedRows.Count > 0) && (DataGridStockIssues.SelectedRows.Count > 0))
                {
                    if (DataGridStockIssues.SelectedRows[0].Cells[0].Value is null)
                    {
                        MessageBox.Show("Select a rcord with data");

                    }
                    else
                    {
                        if (DateTime.Now > Convert.ToDateTime(DataGridStockIssues.SelectedRows[0].Cells[4].Value))
                        {
                            throw new CustomException("Select a pending stock issue");
                        }
                        else
                        {

                        }
                        StockDAL.StockIssueResolved(Convert.ToInt32(DataGridStockIssues.SelectedRows[0].Cells[0].Value),
                        DataGridStockIssues.SelectedRows[0].Cells[4].Value.ToString());

                        StockDAL.AddStock(Convert.ToInt32(DataGridStockIssues.SelectedRows[0].Cells[0].Value),
                                Convert.ToInt32(DataGridStockIssues.SelectedRows[0].Cells[2].Value));
                        populateDataGrids();
                        MessageBox.Show("Yay! Issue resolved.  Stock levels have now been updated");
                    }


                }
                else
                {
                    MessageBox.Show("Select a record!");
                }
            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred");
            }
           
        }

        private void btnPendingIssues_Click(object sender, EventArgs e)
        {
            PopulatePendingIssues();
        }

        private void btnIssueHistory_Click(object sender, EventArgs e)
        {
            populateDataGrids();

        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            if ((DataGridStockIssues.SelectedRows.Count > 0) && (DataGridStockIssues.SelectedRows.Count > 0))
            {
                if (DataGridStockIssues.SelectedRows[0].Cells[0].Value is null)
                {
                    MessageBox.Show("Select a rcord with data");

                }
                else
                {
                    StockDAL.StockIssueResolved(Convert.ToInt32(DataGridStockIssues.SelectedRows[0].Cells[0].Value),
                    DataGridStockIssues.SelectedRows[0].Cells[4].Value.ToString());

                    populateDataGrids();
                    MessageBox.Show("Yay! Issue resolved. REFUND??");
                }


            }
            else
            {
                MessageBox.Show("Select a record!");
            }
        }

        private void btnKept_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlIssueResolvedHide_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
