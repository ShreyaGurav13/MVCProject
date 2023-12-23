using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Employeef1
    {
        public int Eid { get; set; }
        public string Name { get; set; } = null!;
        public string? Designation { get; set; }
        public float? Ctc { get; set; }
        public float? Gross { get; set; }
        public float? Pf { get; set; }
        public float? Inhand { get; set; }
    }
}
