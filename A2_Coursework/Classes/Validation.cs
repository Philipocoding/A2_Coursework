using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A2_Coursework.Classes
{
    public class Validation
    {
        public static bool ValidGender(string gender)
        {
            if((gender.ToLower() != "male")&&(gender.ToLower() !="female")&&(gender.ToLower() != "other"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidTeamNo(string teamNo)
        {
            int team = Convert.ToInt32(teamNo);
            if ((team<1)||(team>3))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool isNullorEmpty(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool validAge(int age)
        {
            if ((age < 16)|| (age > 99))
            {
                return false;
            }
            return true;
        }

        public static bool ValidService(string service)
        {
            foreach (var key in Booking.Booking_Requests.Keys)
            {
                if (key.ToLower() == service.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
