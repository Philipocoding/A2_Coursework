using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Coursework.Classes
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double HourlyRate { get; set; }
        public int TeamNo { get; set; }

        public Staff() { }
        public Staff(int staffID, string firstname, string surname, string gender, int age, double hourlyRate, int teamNo)
        {
            StaffID = staffID;
            Firstname = firstname;
            Surname = surname;
            Gender = gender;
            Age = age;
            HourlyRate = hourlyRate;
            TeamNo = teamNo;
        }

        public static List<Staff> populateDataGrid()
        {
            List<Staff> StaffMembers = new List<Staff>();

            try
            {
                using (SqlConnection connection = new SqlConnection(BookingDAL.connectionString))
                {
                    connection.Open();

                    SqlCommand GetStaff = new SqlCommand();

                    GetStaff.Connection = connection;
                    GetStaff.CommandType = System.Data.CommandType.StoredProcedure;
                    GetStaff.CommandText = "RetrieveStaffMembers";

                    using (SqlDataReader reader = GetStaff.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Staff staffmember = new Staff();

                            staffmember.StaffID = Convert.ToInt32(reader["StaffID"]);
                            staffmember.Firstname = reader["Firstname"].ToString();
                            staffmember.Surname = reader["Surname"].ToString();
                            staffmember.Age = Convert.ToInt32(reader["Age"]);
                            staffmember.Gender = reader["Gender"].ToString();
                            staffmember.HourlyRate = Convert.ToInt32(reader["HourlyRate"]);
                            staffmember.TeamNo = Convert.ToInt32(reader["TeamNo"]);
                            StaffMembers.Add(staffmember);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return StaffMembers;
        }
    }
}
