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

        // Constructor to accept the MainMenu instance
        public ViewStockLevels(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
        }

        public void OpenFormFromOtherClass()
        {
            // Use the openChildForm method
            _mainMenu.openChildForm(new NewBooking());
        }

        private void ViewStockLevels_Load(object sender, EventArgs e)
        {
            cmbStock.Items.Clear();

            List<Stock> items = StockDAL.GetEquipmentInfo();
            foreach (Stock item in items)
            {
                if (!Stock.StockIds.ContainsKey(item.StockID))
                {
                    Stock.StockIds.Add(item.StockID, item);

                }

                if (!Stock.StockIDs.ContainsKey(item.StockName))
                {
                    Stock.StockIDs.Add(item.StockName, item);

                }

            }
            foreach (Stock item in StockDAL.GetEquipmentInfo())
            {
                double cost = StockDAL.GetStockPrice(item.StockID);
                dataGridStock.Rows.Add(item.StockID.ToString(), Stock.StockIds[item.StockID].StockName.ToString(),
                    item.Quantity.ToString(), cost.ToString());
                cmbStock.Items.Add(Stock.StockIds[item.StockID].StockName.ToString());
            }
        }

        private void btnAutoOrder_Click(object sender, EventArgs e)
        {
            pnlReorder.Visible = true;

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            pnlReorder.Visible = false;
            int quantity = Convert.ToInt32(cmbQuantity.Text);
            string stock = cmbStock.Text;
            int reorderValue = Convert.ToInt32(cmbReorderLevel.Text);
        }

        private void btnReorderStock_Click(object sender, EventArgs e)
        {
            OpenFormFromOtherClass();

        }
    }
}
