using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunsNRoses.Model
{
    public enum UserRole
    {
        Admin,
        Visitor
    }
    public class User
    {
        public string UsertName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

        public User(string username, string password, UserRole role)
        {
            this.UsertName = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
