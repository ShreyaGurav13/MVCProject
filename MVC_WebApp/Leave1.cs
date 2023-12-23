using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Leave1
    {
        public int? Id { get; set; }
        public int LeaveId { get; set; }
        public DateTime? LDate { get; set; }
        public string Reason { get; set; } = null!;
    }
}
