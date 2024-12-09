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
    public partial class NewBooking : Form
    {
        public NewBooking()
        {
            InitializeComponent();
        }

        List<int> services = new List<int>();
        bool windows = false;
        bool Floors = false;
        bool Doors = false;
        bool Dusting = false;
        bool Bathroom = false;
        bool Carpet = false;
        bool Curtains = false;
        bool Vacuum = false;



        public void ButtonSelect()
        {

        }
        private void btnWindows_Click(object sender, EventArgs e)
        {
            if (btnWindows.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnWindows.Font = new Font(btnWindows.Font.FontFamily, btnWindows.Font.Size, FontStyle.Regular);
                windows = true;
            }
            else
            {
                btnWindows.Font = new Font(btnWindows.Font, FontStyle.Bold);
                windows = false;
            }

        }

        private void btnFloors_Click(object sender, EventArgs e)
        {
            if (btnFloors.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnFloors.Font = new Font(btnFloors.Font.FontFamily, btnFloors.Font.Size, FontStyle.Regular);
                Floors = true;
            }
            else
            {
                btnFloors.Font = new Font(btnFloors.Font, FontStyle.Bold);
                Floors = false;
            }
        }

        private void btnDoors_Click(object sender, EventArgs e)
        {
            if (btnDoors.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnDoors.Font = new Font(btnDoors.Font.FontFamily, btnDoors.Font.Size, FontStyle.Regular);
                Doors = true;
            }
            else
            {
                btnDoors.Font = new Font(btnDoors.Font, FontStyle.Bold);
                Doors = false;
            }
        }

        private void btnDusting_Click(object sender, EventArgs e)
        {
            if (btnDusting.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnDusting.Font = new Font(btnDusting.Font.FontFamily, btnDusting.Font.Size, FontStyle.Regular);
                Dusting = true;
            }
            else
            {
                btnDusting.Font = new Font(btnDusting.Font, FontStyle.Bold);
                Dusting = false;
            }
        }

        private void btnBathrooms_Click(object sender, EventArgs e)
        {
            if (btnBathrooms.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnBathrooms.Font = new Font(btnBathrooms.Font.FontFamily, btnBathrooms.Font.Size, FontStyle.Regular);
                Bathroom = true;
            }
            else
            {
                btnBathrooms.Font = new Font(btnBathrooms.Font, FontStyle.Bold);
                Bathroom = false;
            }
        }



        private void btnVacuuming_Click(object sender, EventArgs e)
        {
            if (btnCarpets.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnCarpets.Font = new Font(btnCarpets.Font.FontFamily, btnCarpets.Font.Size, FontStyle.Regular);
                Carpet = true;
            }
            else
            {
                btnCarpets.Font = new Font(btnCarpets.Font, FontStyle.Bold);
                Carpet = false;
            }
        }

        private void btnCurtains_Click(object sender, EventArgs e)
        {
            if (btnCurtains.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnCurtains.Font = new Font(btnCurtains.Font.FontFamily, btnCarpets.Font.Size, FontStyle.Regular);
                Curtains = true;
            }
            else
            {
                btnCurtains.Font = new Font(btnCurtains.Font, FontStyle.Bold);
                Curtains = false;
            }
        }

        private void btnRoomVacuum_Click(object sender, EventArgs e)
        {
            if (btnRoomVacuum.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnRoomVacuum.Font = new Font(btnRoomVacuum.Font.FontFamily, btnRoomVacuum.Font.Size, FontStyle.Regular);
                Vacuum = true;
            }
            else
            {
                btnRoomVacuum.Font = new Font(btnRoomVacuum.Font, FontStyle.Bold);
                Vacuum = false;
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            services.Clear();
            if (windows) { services.Add(1); }
            if (Floors) { services.Add(2); }
            if (Doors) { services.Add(3); }
            if (Dusting) { services.Add(4); }
            if (Bathroom) { services.Add(5); }
            if (Carpet) { services.Add(6); }
            if (Curtains) { services.Add(7); }
            if (Vacuum) { services.Add(8); }

            int customerID = Convert.ToInt32(txtbCustomerID.Text);
            string theDate = DTPicker.Value.ToShortDateString();
            ProjectDAL.NewBooking(customerID, theDate, services);
        }
    }
}
