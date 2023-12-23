using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Patient
    {
        public int Pid { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Address { get; set; } = null!;
        public string? Mobno { get; set; }
        public string Dept { get; set; } = null!;
        public string Drnm { get; set; } = null!;
    }
}
