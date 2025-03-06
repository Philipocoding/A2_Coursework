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
            try
            {
                if (dtPicker.Value.AddYears(18) >= DateTime.Now)
                {
                    throw new CustomException("Customer must be 18 years of age or older");
                }
                else
                {
                    string dateString = dtPicker.Value.ToString("yyyy/MM/dd");
                    if (Validation.ValidGender(cmbGender.Text))
                    {
                        if ((Validation.isNullorEmpty(txtbFirstname.Text) && (Validation.isNullorEmpty(txtbFirstname.Text))
                            && (Validation.isNullorEmpty(txtbEmail.Text)) && (Validation.isNullorEmpty(txtbAddressTwo.Text)) && (Validation.isNullorEmpty(txtbAddressOne.Text)
                            && (Validation.isNullorEmpty(cmbGender.Text)) && (Validation.isNullorEmpty(dtPicker.Text)))))
                        {
                            BookingDAL.NewCustomer(txtbFirstname.Text, txtbSurname.Text, dateString, cmbGender.Text,
                            txtbAddressOne.Text, txtbAddressTwo.Text, txtbEmail.Text);
                            MessageBox.Show("Customer Added");
                            txtbFirstname.Text = "";
                            txtbSurname.Text = "";
                            txtbEmail.Text = "";
                            txtbAddressTwo.Text = "";
                            txtbAddressOne.Text = "";
                            cmbGender.Text = "";
                            dtPicker.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            MessageBox.Show("Ensure all fields are sensibly completed");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter valid gender");
                    }
                }
                

            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
           

        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
