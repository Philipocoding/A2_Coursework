﻿using A2_Coursework.Classes;
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
        List<Booking> bookings = new();
        List<Customer> customers = new();
        public BookingSchedules()
        {
            InitializeComponent();
            dataGridOne.MouseDown += DataGridView_MouseDown;
            dataGrid2.MouseDown += DataGridView_MouseDown;
            dataGrid3.MouseDown += DataGridView_MouseDown;
            dataGrid4.MouseDown += DataGridView_MouseDown;
            dataGrid5.MouseDown += DataGridView_MouseDown;
        }
        private DataGridViewRow GetSelectedRow()
        {
            var grids = new[] { dataGridOne, dataGrid2, dataGrid3, dataGrid4, dataGrid5};

            foreach (var grid in grids)
            {
                if (grid.SelectedRows.Count > 0)
                {
                    return grid.SelectedRows[0]; 
                }
            }

            return null;
        }
        void StyleDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = true;
            dgv.RowHeadersWidth = 30;
        }

        void ApplyStyles()
        {
            StyleDataGridView(dataGridOne);
            StyleDataGridView(dataGrid2);
            StyleDataGridView(dataGrid3);
            StyleDataGridView(dataGrid4);
            StyleDataGridView(dataGrid5);
        }
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is DataGridView currentGrid)
            {
                // Deselect rows in other grids
                foreach (var grid in new[] { dataGridOne, dataGrid2, dataGrid3, dataGrid4, dataGrid5 })
                {
                    if (grid != currentGrid)
                    {
                        grid.ClearSelection();
                    }
                }

                // Ensure the clicked row is selected
                var hitTest = currentGrid.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    currentGrid.Rows[hitTest.RowIndex].Selected = true;
                }
            }
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
            PopulateDataGrid();
        }
        private void PopulateDataGrid()
        {
            getData(DtPicker.Value.ToString("dd/MM/yyyy"));
            dataGridOne.Rows.Clear();
            //List<Booking> allbookings = new();
            //allbookings = Booking.populateDataGrid();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGridOne.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
            PopulateDataGridTwo();
            PopulateDataGridThree();
            PopulateDataGridFour();
            PopulateDataGridFive();
        }
        private void PopulateDataGridTwo()
        {
            getData(DtPicker.Value.AddDays(1).ToString("dd/MM/yyyy"));
            dataGrid2.Rows.Clear();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid2.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void PopulateDataGridThree()
        {
            getData(DtPicker.Value.AddDays(2).ToString("dd/MM/yyyy"));
            dataGrid3.Rows.Clear();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid3.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void PopulateDataGridFour()
        {
            getData(DtPicker.Value.AddDays(3).ToString("dd/MM/yyyy"));
            dataGrid4.Rows.Clear();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid4.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void PopulateDataGridFive()
        {
            getData(DtPicker.Value.AddDays(4).ToString("dd/MM/yyyy"));
            dataGrid5.Rows.Clear();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid5.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void BookingSchedules_Load(object sender, EventArgs e)
        {
            updateDates();
            ApplyStyles();
            btnWcOne.Text = Booking.GetUpcomingMonday(DtPicker.Value);
            btnWCTwo.Text = Booking.GetUpcomingMonday(DtPicker.Value.AddDays(7));
            btnWcThree.Text = Booking.GetUpcomingMonday(DtPicker.Value.AddDays(14));
            btnWcFour.Text = Booking.GetUpcomingMonday(DtPicker.Value.AddDays(21));

            PopulateDataGrid();
            
        }
        


        private void getData(string date)
        {
            var result = BookingDAL.GetBookingsByDate(date);

            customers = result.customerList;
            bookings = result.bookingList;

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(-1);

        }

        private void btnPostpone_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedRow();
            if (selectedRow == null)
            {
                MessageBox.Show("Select a row!");
            }
            else
            {
                pnlPostponeDetails.Visible = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedRow();
            pnlPostponeDetails.Visible = false;
            try
            {
                string date = dtPickerPostpone.Value.ToString("dd/MM/yyyy");
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                MessageBox.Show(date);
                BookingDAL.UpdateBookingDate(id, date);
                PopulateDataGrid();
                pnlPostponeDetails.Visible = false;
                MessageBox.Show("Booking updated");

            }
            catch (CustomException ex)
            {

            }
        }

        private void btnWcOne_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWcOne.Text);
        }

        private void btnWCTwo_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWCTwo.Text);

        }

        private void btnWcThree_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWcThree.Text);

        }

        private void btnWcFour_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWcFour.Text);

        }
    }
}
