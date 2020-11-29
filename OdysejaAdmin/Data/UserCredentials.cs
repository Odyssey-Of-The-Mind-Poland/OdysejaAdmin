using System.ComponentModel.DataAnnotations;

namespace OdysejaAdmin.Data
{
    public class UserCredentials
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

        public UserCredentials(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}