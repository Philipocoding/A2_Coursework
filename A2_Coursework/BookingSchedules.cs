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
    public partial class BookingSchedules : Form
    {
        public BookingSchedules()
        {
            InitializeComponent();
        }

        private void updateDates()
        {
            lblDateOne.Text = DtPicker.Value.ToString("dd/MM/yyyy");
            lblDateTwo.Text = DtPicker.Value.AddDays(1).ToString("dd/MM/yyyy");
            lblDateThree.Text = DtPicker.Value.AddDays(2).ToString("dd/MM/yyyy");
            lblDateFour.Text = DtPicker.Value.AddDays(3).ToString("dd/MM/yyyy");
            lblDateFive.Text = DtPicker.Value.AddDays(4).ToString("dd/MM/yyyy");

        }
        private void DtPicker_ValueChanged(object sender, EventArgs e)
        {
            updateDates();
        }

        private void BookingSchedules_Load(object sender, EventArgs e)
        {
            updateDates();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(-1);

        }
    }
}
