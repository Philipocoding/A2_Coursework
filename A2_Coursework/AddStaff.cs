﻿using System;
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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ProjectDAL.NewStaffMember(txtbFirstname.Text, txtbSurname.Text, txtbGender.Text, Convert.ToInt32(txtbAge.Text), float.Parse(txtbHourlyRate.Text),1);
        }
    }
}