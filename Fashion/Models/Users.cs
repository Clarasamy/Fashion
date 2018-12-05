using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashion.Models
{
    public class Users
    {

        public int ID;
        public string Email { get; set; }
        public string Password { get; set; }
        



        public static bool Log(string Email, string password)
        {
            if (Email == "admin@admin" && password == "admin")
                return true;
            else
                return false;

        }


    }
}
