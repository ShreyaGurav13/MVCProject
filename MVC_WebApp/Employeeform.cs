using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Employeeform
    {
        public Employeeform()
        {
            Leave11s = new HashSet<Leave11>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public double Ctc { get; set; }
        public double Gross { get; set; }
        public double Tax { get; set; }
        public double Pf { get; set; }
        public double InHand { get; set; }

        public virtual ICollection<Leave11> Leave11s { get; set; }
    }
}
