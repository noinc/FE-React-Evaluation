using System.ComponentModel.DataAnnotations;

namespace NoInc.Controllers
{
    /// <summary>
    /// Login credentials for a user
    /// </summary>
    public class UserCredentials
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}