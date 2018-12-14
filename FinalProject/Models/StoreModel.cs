using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FinalProject.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string userid { get; set; }
        public int itemid { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string items { get; set; }
        public float total { get; set; }
        public string userid { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
    }
}