
using System.ComponentModel.DataAnnotations;
namespace GuestBook.data.Model
{
    public class User
    {

        public int id { get; set; }

        [Required, MinLength(5), MaxLength(32)]
        public string Username { get; set; }

        [Required, MinLength(8), MaxLength(32)]
        public string Password { get; set; }
    }
}
