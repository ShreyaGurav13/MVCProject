using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Leave11
    {
        public int LeaveId { get; set; }
        public int? Id { get; set; }
        public DateTime? LDate { get; set; }
        public string Reason { get; set; } = null!;

        public virtual Employeeform? IdNavigation { get; set; }
    }
}
