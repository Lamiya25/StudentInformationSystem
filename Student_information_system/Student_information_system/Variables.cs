using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_information_system
{
    static class Variables
    {
        static string std_id = "";
        public static string userId
        {
            set { std_id = value; }
            get { return std_id; }
        }
    }
}