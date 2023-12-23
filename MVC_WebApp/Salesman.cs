using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Salesman
    {
        public Salesman()
        {
            Customers = new HashSet<Customer>();
        }

        public int SalesmanId { get; set; }
        public string SalesmanName { get; set; } = null!;
        public string City { get; set; } = null!;
        public int Commition { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
