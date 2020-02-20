using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.Models
{
    public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsPassword { get; set; } = true;
        public string Image { get; set; }
    }
}
