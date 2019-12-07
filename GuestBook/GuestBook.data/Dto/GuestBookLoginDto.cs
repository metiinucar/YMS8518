using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GuestBook.data.Dto
{
     public class GuestBookLoginDto
    {
        [Required, MinLength(5), MaxLength(32)]
        public string UserName { get; set; }

        [Required, MinLength(8), MaxLength(32)]
        public string Password { get; set; }
    }
}
