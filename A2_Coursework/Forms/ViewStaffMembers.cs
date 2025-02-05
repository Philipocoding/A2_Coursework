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

        private void ViewStaffMembers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateDataGrid();
                pnlDetails.Visible = false;
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

        private void DataGridStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlDetails.Visible = true;
            txtbFirstname.Text = DataGridStaff.SelectedRows[0].Cells["clmFirstname"].Value.ToString();
            txtbSurname.Text = DataGridStaff.SelectedRows[0].Cells["clmSurname"].Value.ToString();
            txtbAge.Text = DataGridStaff.SelectedRows[0].Cells["clmAge"].Value.ToString();
            txtbGender.Text = DataGridStaff.SelectedRows[0].Cells["clmGender"].Value.ToString();
            txtbTeamNo.Text = DataGridStaff.SelectedRows[0].Cells["clmTeamNo"].Value.ToString();
            txtbHourlyRate.Text = DataGridStaff.SelectedRows[0].Cells["clmHourlyRate"].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(DataGridStaff.SelectedRows[0].Cells["clmStaffID"].Value);
            BookingDAL.DeleteStaffMember(id);
            PopulateDataGrid();
            pnlDetails.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(DataGridStaff.SelectedRows[0].Cells["clmStaffID"].Value);
            BookingDAL.EditStaff(id, txtbFirstname.Text, txtbSurname.Text, Convert.ToInt32(txtbAge.Text), txtbGender.Text, 
                Convert.ToInt32(txtbHourlyRate.Text), Convert.ToInt32(txtbTeamNo.Text));
            PopulateDataGrid();
            pnlDetails.Visible = false;
        }
    }
}
