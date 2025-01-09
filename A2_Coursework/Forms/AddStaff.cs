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
            if(Convert.ToInt32(txtbHourlyRate.Text) > 100)
            {
                MessageBox.Show("Enter a valid hourly rate");
            }
            else
            {
                ProjectDAL.NewStaffMember(txtbFirstname.Text, txtbSurname.Text, cmbGender.Text, Convert.ToInt32(txtbAge.Text), float.Parse(txtbHourlyRate.Text), 1);

            }
        }

        
    }
}
