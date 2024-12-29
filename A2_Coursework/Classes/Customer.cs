using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Coursework.Classes
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public string Gender {  get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }

        public string Email { get; set; }

        public Customer() { }
        public Customer(int customerID, string firstname, string surname, string dOB,
            string gender, string addressOne, string addressTwo, string email)
        {
            CustomerID = customerID;
            Firstname = firstname;
            Surname = surname;
            DOB = dOB;
            Gender = gender;
            AddressOne = addressOne;
            AddressTwo = addressTwo;
            Email = email;
        }

        public static List<Customer> populateDataGrid()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ProjectDAL.connectionString))
                {
                    connection.Open();

                    SqlCommand GetBookings = new SqlCommand();

                    GetBookings.Connection = connection;
                    GetBookings.CommandType = System.Data.CommandType.StoredProcedure;
                    GetBookings.CommandText = "RetrieveCustomers";

                    using (SqlDataReader reader = GetBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();

                            customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            customer.Firstname = reader["Forename"].ToString();
                            customer.Surname = reader["Surname"].ToString();
                            customer.DOB = (reader["DOB"]).ToString();
                            customer.Gender = reader["Gender"].ToString();
                            customer.AddressOne = reader["AddressOne"].ToString();
                            customer.AddressTwo = reader["AddressTwo"].ToString();
                            customer.Email = reader["Email"].ToString();
                            customers.Add(customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return customers;
        }
    }
}
