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
    public partial class ConfirmForm : Form
    {
        public ConfirmForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        //private void openChildForm(Form childForm)
        //{
        //    activeForm = childForm;

        //    //setup form display settings
        //    activeForm.TopLevel = false;
        //    activeForm.Location = new System.Drawing.Point(0, 0);
        //    activeForm.FormBorderStyle = FormBorderStyle.None;
        //    activeForm.Enabled = true;
        //    activeForm.Visible = true;
        //    activeForm.Dock = DockStyle.Fill;

        //    //display in panel
        //    pnlChildForm.Controls.Clear();
        //    pnlChildForm.Controls.Add(activeForm);
        //    pnlChildForm.Show();

        //}
        private void ConfirmForm_Load(object sender, EventArgs e)
        {

        }
    }
}
