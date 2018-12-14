using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class OrderResult
    {
        public int Id { get; set; }
        public string items { get; set; }
        public float total { get; set; }
        public string userid { get; set; }
    }
}