using System;
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
        public static bool validAge(int age)
        {
            if ((age < 18)|| (age > 115))
            {
                return false;
            }
            return true;
        }
    }
}
