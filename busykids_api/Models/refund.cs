using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace busykids_api.Models
{
    public class Refund
    {
        public int Id { get; set; }
        public int RefundAmount { get; set; }
        public int CustomerId { get; set; }
        public DateTime date { get; set; }
        
    }
}