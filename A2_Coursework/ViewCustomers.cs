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

        private void DataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if((DataGridCustomers.SelectedRows.Count > 0)&&(DataGridCustomers.SelectedRows.Count < 2)){
                txtbFirstname.Text = DataGridCustomers.SelectedRows[0].Cells["clmForename"].Value.ToString();
                txtbSurname.Text = DataGridCustomers.SelectedRows[0].Cells["clmSurname"].Value.ToString();
                txtbDOB.Text = DataGridCustomers.SelectedRows[0].Cells["clmDOB"].Value.ToString();
                txtbGender.Text = DataGridCustomers.SelectedRows[0].Cells["clmGender"].Value.ToString();
                txtbAddressOne.Text = DataGridCustomers.SelectedRows[0].Cells["clmAddressOne"].Value.ToString();
                txtbAddressTwo.Text = DataGridCustomers.SelectedRows[0].Cells["clmAddressTwo"].Value.ToString();
                txtbEmail.Text = DataGridCustomers.SelectedRows[0].Cells["clmEmail"].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectDAL.DeleteCustomer(Convert.ToInt32(DataGridCustomers.SelectedRows[0]
                .Cells["clmCustomerID"].Value));
                PopulateDataGrid();
                MessageBox.Show("Customer deleted");
            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.ValidGender(txtbGender.Text))
                {
                    int id = Convert.ToInt32(DataGridCustomers.SelectedRows[0].Cells["clmCustomerID"].Value);

                    ProjectDAL.EditCustomer(id, txtbFirstname.Text, txtbSurname.Text, txtbDOB.Text, txtbGender.Text, txtbAddressOne.Text,
                        txtbAddressTwo.Text, txtbEmail.Text);
                }
                PopulateDataGrid();
                MessageBox.Show("Updated");
            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
