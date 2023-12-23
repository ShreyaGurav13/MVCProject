using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Stud
    {
        public int Id { get; set; }
        public string Nm { get; set; } = null!;
        public double Per { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
