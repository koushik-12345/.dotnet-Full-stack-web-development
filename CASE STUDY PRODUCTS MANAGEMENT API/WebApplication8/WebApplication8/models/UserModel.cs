using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication8.Models
{
    // It is for processing with database, integrte with Entity Framework
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

}