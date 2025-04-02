using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoChallenge
{
    public static class SessionManager
    {
        public static int UserID { get; set; } = -1;  // Default value (not logged in)
        public static string Username { get; set; }
    }

}
