﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if ((age < 18)|| (age > 115))
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
    }
}
