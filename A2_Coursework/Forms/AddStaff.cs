using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2_Coursework.Classes;

namespace A2_Coursework
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtbHourlyRate.Text) > 50)
                {
                    MessageBox.Show("Enter a valid hourly rate");
                }
                else
                {
                    if ((Validation.ValidGender(cmbGender.Text)) && (Validation.validAge(Convert.ToInt32(txtbAge.Text))) && (Validation.ValidTeamNo(cmbTeamNo.Text)))
                    {
                        BookingDAL.NewStaffMember(txtbFirstname.Text, txtbSurname.Text, cmbGender.Text,
                       Convert.ToInt32(txtbAge.Text), float.Parse(txtbHourlyRate.Text), Convert.ToInt32(cmbTeamNo.Text));
                        MessageBox.Show("Staff member added!");
                        txtbFirstname.Text = "";
                        txtbSurname.Text = "";
                        txtbHourlyRate.Text = "";
                        txtbAge.Text = "";
                        cmbGender.Text = "";
                        cmbTeamNo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ensure all details are sensible and valid");
                    }

                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error occurred when trying to add staff member");
            }
           
        }

        
    }
}
