using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class ViewStudent
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Age { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
    }
}
