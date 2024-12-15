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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dateString = dtPicker.Value.ToString("yyyy-MM-dd");
            ProjectDAL.NewCustomer(txtbFirstname.Text, txtbSurname.Text, dateString, txtbGender.Text,
                txtbAddressOne.Text, txtbAddressTwo.Text, txtbEmail.Text);
        }
    }
}
