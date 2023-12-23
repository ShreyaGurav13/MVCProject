using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; } = null!;
        public string CustCity { get; set; } = null!;
        public string CustGrade { get; set; } = null!;
        public int? FkcustId { get; set; }

        public virtual Salesman? Fkcust { get; set; }
    }
}
