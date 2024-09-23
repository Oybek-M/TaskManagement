using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskChain.Models.Commons;

namespace TaskChain.Models
{
    public class Permission : Auditable
    {
        public bool ChangePermit { get; set; }
        public bool ViewPermit { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}