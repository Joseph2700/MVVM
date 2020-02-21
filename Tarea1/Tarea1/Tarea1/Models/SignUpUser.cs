using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.Models
{
    public class SignUpUser
    {
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public bool IsPassword { get; set; } = true;
    }
}
