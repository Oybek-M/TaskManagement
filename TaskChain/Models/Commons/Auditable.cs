using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskChain.Models.Commons
{
    public class Auditable
    {
        public int ID { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get;set; }
        public bool IsDeleted { get; set; } = false;
    }
}