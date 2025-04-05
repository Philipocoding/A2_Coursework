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
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
            StyleDatagridview();

        }
        void StyleDatagridview()
        {
            foreach (DataGridViewColumn col in DataGridCustomers.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            DataGridCustomers.BorderStyle = BorderStyle.Fixed3D;
            DataGridCustomers.BackgroundColor = Color.White;
            DataGridCustomers.GridColor = Color.LightGray;
            DataGridCustomers.EnableHeadersVisualStyles = false;
            DataGridCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            DataGridCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            DataGridCustomers.DefaultCellStyle.BackColor = Color.White;
            DataGridCustomers.DefaultCellStyle.ForeColor = Color.Black;
            DataGridCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            DataGridCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            DataGridCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridCustomers.RowHeadersVisible = true;
            DataGridCustomers.RowHeadersWidth = 30;
        }
        private void PopulateDataGrid()
        {
            DataGridCustomers.Rows.Clear();
            List<Customer> allCustomers = new();
            allCustomers = Customer.populateDataGrid();
            foreach (Customer customer in allCustomers)
            {
                DataGridCustomers.Rows.Add(customer.CustomerID, customer.Firstname, customer.Surname, customer.DOB
                    , customer.Gender, customer.AddressOne, customer.AddressTwo, customer.Email);
            }
        }
        private void PopulateDataGrid(Customer customer)
        {
            DataGridCustomers.Rows.Clear();
            DataGridCustomers.Rows.Add(customer.CustomerID, customer.Firstname, customer.Surname, customer.DOB
                , customer.Gender, customer.AddressOne, customer.AddressTwo, customer.Email);

        }

        private void DataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridCustomers.SelectedRows[0].Cells[0].Value is null)
            {
                MessageBox.Show("Select a record with data!");
            }
            else
            {
                if ((DataGridCustomers.SelectedRows.Count > 0) && (DataGridCustomers.SelectedRows.Count < 2))
                {
                    txtbFirstname.Text = DataGridCustomers.SelectedRows[0].Cells["clmForename"].Value.ToString();
                    txtbSurname.Text = DataGridCustomers.SelectedRows[0].Cells["clmSurname"].Value.ToString();
                    dtPicketDOB.Text = DataGridCustomers.SelectedRows[0].Cells["clmDOB"].Value.ToString();
                    cmbGender.Text = DataGridCustomers.SelectedRows[0].Cells["clmGender"].Value.ToString();
                    txtbAddressOne.Text = DataGridCustomers.SelectedRows[0].Cells["clmAddressOne"].Value.ToString();
                    txtbAddressTwo.Text = DataGridCustomers.SelectedRows[0].Cells["clmAddressTwo"].Value.ToString();
                    txtbEmail.Text = DataGridCustomers.SelectedRows[0].Cells["clmEmail"].Value.ToString();

                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BookingDAL.DeleteCustomer(Convert.ToInt32(DataGridCustomers.SelectedRows[0]
                .Cells[0].Value));
                PopulateDataGrid();
                MessageBox.Show("Customer deleted");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtPicketDOB.Value.AddYears(18) <= DateTime.Now)
            {
                try
                {
                    if (Validation.ValidGender(cmbGender.Text))
                    {
                        if (Validation.IsValidEmail(txtbEmail.Text))
                        {
                            int id = Convert.ToInt32(DataGridCustomers.SelectedRows[0].Cells["clmCustomerID"].Value);

                            BookingDAL.EditCustomer(id, txtbFirstname.Text, txtbSurname.Text, dtPicketDOB.Text, cmbGender.Text, txtbAddressOne.Text,
                                txtbAddressTwo.Text, txtbEmail.Text);
                        }
                        else
                        {
                            throw new CustomException("Invalid email format");
                        }

                    }
                    PopulateDataGrid();
                    MessageBox.Show("Updated");
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Customer must be 18 or older");
            }


        }

        private void DataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pnlEdit.Visible)
            {
                pnlEdit.Visible = false;
            }
            else
            {
                try
                {
                    if (DataGridCustomers.SelectedRows[0].Cells[0].Value is null)
                    {
                        MessageBox.Show("Select a record with data!");
                    }
                    else
                    {
                        if ((DataGridCustomers.SelectedRows.Count > 0) && (DataGridCustomers.SelectedRows.Count < 2))
                        {
                            pnlEdit.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Select a record!");
                        }
                    }
                }
                catch (CustomException ex)
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occured! Have you selected a record?");

                }

            }


        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridCustomers.SelectedRows[0].Cells[0].Value is null)
                {
                    MessageBox.Show("Select a record with data!");
                }
                else
                {
                    if ((DataGridCustomers.SelectedRows.Count > 0) && (DataGridCustomers.SelectedRows.Count < 2))
                    {
                        try
                        {
                            BookingDAL.DeleteCustomer(Convert.ToInt32(DataGridCustomers.SelectedRows[0]
                            .Cells[0].Value));
                            PopulateDataGrid();
                            MessageBox.Show("Customer deleted");
                        }
                        catch (CustomException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a record!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.  Have you selected a record?");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtbSearch.Text);
                PopulateDataGrid(BookingDAL.GetCustomer(id));
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");
                txtbSearch.Text = "Enter customer ID";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
            txtbSearch.Text = "Enter customer ID";
        }

        private void txtbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbSearch.Text == "Enter customer ID")
            {
                txtbSearch.Text = "";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtbFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int id = Convert.ToInt32(txtbSearch.Text);
                    PopulateDataGrid(BookingDAL.GetCustomer(id));
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred");
                    txtbSearch.Text = "Enter customer ID";

                }
            }
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
