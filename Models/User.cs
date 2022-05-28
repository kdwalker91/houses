using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public bool Text { get; set; }
        public bool Call { get; set; }
        public string Email { get; set; }

        [NotMapped]
        public string NickName { get; set; }
    }
}
