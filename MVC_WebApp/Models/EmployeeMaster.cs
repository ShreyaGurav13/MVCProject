using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_WebApp.Models
{
    public class EmployeeMaster
    {
        [Key]
        [Required]
        [DisplayName("EmployeeID")]
        [Range(1,99999)]
        public int empid { get; set; }

        [Required]
        [DisplayName("EmployeeName")]
        public string? empname { get; set; } = "";

        [Required]
        [DisplayName("Designation")]
        public string? designation { get; set; } = "";

        [Required]
        [DisplayName("Gross Salary")]
        public double? grossal { get; set; }

        [Required]
        [DisplayName("Deduction")]
        public double? deduction { get; set; }

        [Required]
        [DisplayName("Net Salary")]
        public double? netsal { get; set; }

        [Required]
        [DisplayName("Is Active")]
        public string isactive { get; set; }
    }
}
