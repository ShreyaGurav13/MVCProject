using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Empmaster
    {
        public int Empid { get; set; }
        public string Empnm { get; set; } = null!;
        public string? Designation { get; set; }
        public float? Grosssal { get; set; }
        public float? Deduction { get; set; }
        public float? Netsal { get; set; }
        public string? Isactive { get; set; }
    }
}
