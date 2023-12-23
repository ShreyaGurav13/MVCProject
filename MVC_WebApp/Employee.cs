using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Employee
    {
        public int Empid { get; set; }
        public string Empfnm { get; set; } = null!;
        public string Emplnm { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public string? Empmail { get; set; }
        public string Salary { get; set; } = null!;
        public string State { get; set; } = null!;
        public DateTime? JoiningDate { get; set; }
    }
}
