using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_WebApp.Models
{
    public partial class Employeeasp
    {
        public int Eid { get; set; }

        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; } = null!;
        public string? Designation { get; set; }
        public float? Gross { get; set; }
        public float? Deduction { get; set; }
        public float? Netsal { get; set; }
        public string? Isactive { get; set; }
    }
}
