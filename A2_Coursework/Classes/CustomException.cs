using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Coursework.Classes
{
    internal class CustomException:Exception
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
    }
}
