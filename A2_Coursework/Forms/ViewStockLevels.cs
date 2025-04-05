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
    public partial class ViewStockLevels : Form
    {
        public ViewStockLevels()
        {
            InitializeComponent();
        }

        private MainMenu _mainMenu;

        public ViewStockLevels(MainMenu mainMenu)
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
        public void OpenFormFromOtherClass()
        {
            // Use the openChildForm method
            _mainMenu.openChildForm(new NewBooking());
        }
        void ApplyStyles()
        {
            StyleDataGridView(dataGridStock);
        }
        private void ViewStockLevels_Load(object sender, EventArgs e)
        {
            ApplyStyles();
            cmbStock.Items.Clear();
            List<Stock> items = StockDAL.GetEquipmentInfo();


            foreach (Stock item in items)
            {
                cmbStock.Items.Add(Stock.StockIds[item.StockID].StockName.ToString());
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
           
        }

        private void populateDataGrids()
        {
            dataGridStock.Rows.Clear();

            foreach (Stock item in StockDAL.GetEquipmentInfo())
            {
                string status = "Low";
                if ((item.Quantity > 10) && (item.Quantity < 50))
                {
                    status = "Moderate";
                }
                if (item.Quantity > 50)
                {
                    status = "High";
                }
                double cost = StockDAL.GetStockPrice(item.StockID);
                dataGridStock.Rows.Add(item.StockID.ToString(), Stock.StockIds[item.StockID].StockName.ToString(),
                    item.Quantity.ToString(), status,item.ReorderQuantity.ToString(), item.ReorderValue.ToString(), cost.ToString());

            }

            foreach (DataGridViewRow row in dataGridStock.Rows)
            {
                if (row.Cells["clmStatus"].Value != null)
                {
                    string stockLevel = row.Cells["clmStatus"].Value.ToString();

                    switch (stockLevel)
                    {
                        case "Low":
                            row.Cells["clmStatus"].Style.ForeColor = Color.Red;
                            row.Cells["clmStatus"].Style.Font = new Font(dataGridStock.DefaultCellStyle.Font, FontStyle.Bold);
                            break;

                        case "Moderate":
                            row.Cells["clmStatus"].Style.ForeColor = Color.Orange;
                            row.Cells["clmStatus"].Style.Font = new Font(dataGridStock.DefaultCellStyle.Font, FontStyle.Bold);
                            break;

                        case "High":
                            row.Cells["clmStatus"].Style.ForeColor = Color.Green;
                            row.Cells["clmStatus"].Style.Font = new Font(dataGridStock.DefaultCellStyle.Font, FontStyle.Bold);
                            break;
                    }
                }
            }
            
        }

        private void btnAutoOrder_Click(object sender, EventArgs e)
        {
            if (pnlReorder.Visible)
            {
                pnlReorder.Visible = false;
            }
            else
            {
                pnlReorder.Visible = true;

            }

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(txtbQuantity.Text);
                if((quantity<1) || (quantity > 100))
                {
                    throw new CustomException("Invalid quantity");
                }
                string stock = cmbStock.Text;
                int reorderValue = Convert.ToInt32(txtbReorderLevel.Text);
                if ((reorderValue < 1) || (reorderValue > 400))
                {
                    throw new CustomException("Invalid reorder amount");
                }
                StockDAL.AutoOrderStock(Stock.StockIDs[cmbStock.Text].StockID, reorderValue, quantity);
                MessageBox.Show("Automatic reorder created");
                populateDataGrids();
                pnlReorder.Visible = false;


            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("AN error occurred");
            }
           
        }

        private void btnReorderStock_Click(object sender, EventArgs e)
        {
            OpenFormFromOtherClass();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmIssue_Click(object sender, EventArgs e)
        {
            
        }

        private void STockIssueResolved_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void btnKept_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlIssueResolvedHide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
