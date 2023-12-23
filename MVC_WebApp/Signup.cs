using System;
using System.Collections.Generic;

namespace MVC_WebApp
{
    public partial class Signup
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Password { get; set; }
        public string ConfirmPass { get; set; } = null!;
    }
}
