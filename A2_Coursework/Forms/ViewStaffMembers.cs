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
    public partial class ViewStaffMembers : Form
    {
        internal int id;
        public ViewStaffMembers()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        void StyleDataGridView()
        {
            foreach (DataGridViewColumn col in DataGridStaff.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataGridStaff.BorderStyle = BorderStyle.Fixed3D;
            DataGridStaff.BackgroundColor = Color.White;
            DataGridStaff.GridColor = Color.LightGray;
            DataGridStaff.EnableHeadersVisualStyles = false;
            DataGridStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridStaff.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            DataGridStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            DataGridStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridStaff.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            DataGridStaff.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            DataGridStaff.DefaultCellStyle.BackColor = Color.White;
            DataGridStaff.DefaultCellStyle.ForeColor = Color.Black;
            DataGridStaff.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            DataGridStaff.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            DataGridStaff.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridStaff.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridStaff.RowHeadersVisible = true;
            DataGridStaff.RowHeadersWidth = 30;
        }
        private void ViewStaffMembers_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            try
            {
                PopulateDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form: " + ex.Message);
            }

        }



        private void PopulateDataGrid()
        {
            DataGridStaff.Rows.Clear();
            List<Staff> allStaff = new();
            allStaff = Staff.populateDataGrid();
            foreach (Staff staff in allStaff)
            {
                DataGridStaff.Rows.Add(staff.StaffID, staff.Firstname, staff.Surname, staff.Gender,
                    staff.Age, staff.HourlyRate, staff.TeamNo);
            }
        }
        private void PopulateDataGrid(Staff staff)
        {
            DataGridStaff.Rows.Clear();
            {
                DataGridStaff.Rows.Add(staff.StaffID, staff.Firstname, staff.Surname, staff.Gender,
                    staff.Age, staff.HourlyRate, staff.TeamNo);
            }
        }

        private void DataGridStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridStaff.SelectedRows[0].Cells[0].Value is null)
                {
                    MessageBox.Show("Select a rcord with data");

                }
                else
                {
                    txtbFirstname.Text = DataGridStaff.SelectedRows[0].Cells["clmFirstname"].Value.ToString();
                    txtbSurname.Text = DataGridStaff.SelectedRows[0].Cells["clmSurname"].Value.ToString();
                    txtbAge.Text = DataGridStaff.SelectedRows[0].Cells["clmAge"].Value.ToString();
                    txtbGender.Text = DataGridStaff.SelectedRows[0].Cells["clmGender"].Value.ToString();
                    cmbTeamNo.Text = DataGridStaff.SelectedRows[0].Cells["clmTeamNo"].Value.ToString();
                    txtbHourlyRate.Text = DataGridStaff.SelectedRows[0].Cells["clmHourlyRate"].Value.ToString();
                }

            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Select a rcord with data");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(txtbAge.Text);
                int teamNo = Convert.ToInt32(cmbTeamNo.Text);
                if ((teamNo > 3) || (teamNo < 1))
                {
                    MessageBox.Show("Invalid team number");
                }
                else
                {
                    if ((age < 16) || (age > 75))
                    {
                        throw new CustomException("Invalid age");
                    }
                    else
                    {
                        if (Validation.ValidGender(txtbGender.Text))
                        {
                            if ((Convert.ToInt32(txtbHourlyRate.Text) > 50) || (Convert.ToInt32(txtbHourlyRate.Text) < 5))
                            {
                                throw new CustomException("Invalid hourly rate!");
                            }
                            else
                            {
                                id = Convert.ToInt32(DataGridStaff.SelectedRows[0].Cells["clmStaffID"].Value);
                                BookingDAL.EditStaff(id, txtbFirstname.Text, txtbSurname.Text, age, txtbGender.Text,
                                    Convert.ToInt32(txtbHourlyRate.Text), teamNo);
                                PopulateDataGrid();
                                pnlDetails.Visible = false;
                            }

                        }
                        else
                        {
                            throw new CustomException("Invalid gender!");
                        }

                    }

                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Invalid data has been entered");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");
            }


        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if ((DataGridStaff.SelectedRows.Count > 0) && (DataGridStaff.SelectedRows.Count < 2))
            {
                try
                {
                    id = Convert.ToInt32(DataGridStaff.SelectedRows[0].Cells[0].Value);
                    BookingDAL.DeleteStaffMember(id);
                    PopulateDataGrid();
                    MessageBox.Show("Staff member deleted!");
                    pnlDetails.Visible = false;
                }
                catch (CustomException ex)
                {

                }
            }
            else
            {
                MessageBox.Show("Select a record!");
            }

        }

        private void btnDeleteStaffMember_Click(object sender, EventArgs e)
        {
            if ((DataGridStaff.SelectedRows.Count > 0) && (DataGridStaff.SelectedRows.Count < 2))
            {
                if (pnlDetails.Visible)
                {
                    pnlDetails.Visible = false;

                }
                else
                {
                    if (DataGridStaff.SelectedRows[0].Cells[0].Value is null)
                    {
                        MessageBox.Show("Select a rcord with data");
                        pnlDetails.Visible = false;

                    }
                    else
                    {
                        pnlDetails.Visible = true;
                        txtbFirstname.Text = DataGridStaff.SelectedRows[0].Cells["clmFirstname"].Value.ToString();
                        txtbSurname.Text = DataGridStaff.SelectedRows[0].Cells["clmSurname"].Value.ToString();
                        txtbAge.Text = DataGridStaff.SelectedRows[0].Cells["clmAge"].Value.ToString();
                        txtbGender.Text = DataGridStaff.SelectedRows[0].Cells["clmGender"].Value.ToString();
                        cmbTeamNo.Text = DataGridStaff.SelectedRows[0].Cells["clmTeamNo"].Value.ToString();
                        txtbHourlyRate.Text = DataGridStaff.SelectedRows[0].Cells["clmHourlyRate"].Value.ToString();
                    }


                }
            }
            else
            {
                MessageBox.Show("Select a record!");
            }


        }

        private void DataGridStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtbSearch.Text);
                PopulateDataGrid(BookingDAL.GetStaffmember(id));
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");
                txtbSearch.Text = "Enter staff ID";

            }
        }

        private void txtbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbSearch.Text == "Enter staff ID")
            {
                txtbSearch.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
            txtbSearch.Text = "Enter staff ID";
        }

        private void txtbSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int id = Convert.ToInt32(txtbSearch.Text);
                    PopulateDataGrid(BookingDAL.GetStaffmember(id));
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred");
                    txtbSearch.Text = "Enter staff ID";

                }
            }
        }
    }
}
