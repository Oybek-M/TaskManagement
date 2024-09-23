using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TaskChain.Models.Commons;

namespace TaskChain.Models
{
    public class User : Auditable
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Fullname { get; set; }
        public DateTime LastLogIn { get; set; }
        public float Rayting { get; set; }
        public int RoleID { get; set; }
    }
}