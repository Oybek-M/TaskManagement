using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TaskChain.Models.Commons;

namespace TaskChain.Models
{
    public class Role : Auditable
    {
        [Required]
        public string RName { get; set; }
        public string Description { get; set; }
        public int PermissionID { get; set; }
        public Permission Permission { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

    }
}