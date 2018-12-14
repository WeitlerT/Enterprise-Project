using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class OrderController : ApiController
    {
        private StoreModelContext db = new StoreModelContext();

        // GET api/order
        public IEnumerable<Order> Get()
        {
            return db.Order.ToList();
        }

        // GET api/order/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/order
        public void Post([Bind(Include = "Id,items,total,userid")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Order.Add(order);
                db.SaveChanges();
            }
        }

        // PUT api/order/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/order/5
        //public void Delete(int id)
        //{
        //}
    }
}
