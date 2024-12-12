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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ProjectDAL.NewCustomer(txtbFirstname.Text, txtbSurname.Text, txtbDOB.Text, txtbGender.Text,
                Convert.ToInt32(txtbAge.Text), txtbAddressOne.Text, txtbAddressTwo.Text, txtbEmail.Text);
        }
    }
}
