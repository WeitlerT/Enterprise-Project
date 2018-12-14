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
    public class CartController : ApiController
    {
        private StoreModelContext db = new StoreModelContext();

        // GET api/cart
        //public Cart Get()
        //{
        //    return db.Cart.SingleOrDefault(cart => cart.Id == 1);
        //}

        // GET api/cart/5
        //public List<Cart> Get(string id)
        //{
        //    var cartitems = from cart in db.Cart where cart.userid == id select cart;
        //    return cartitems.ToList();
        //}

        // POST api/cart
        public Cart Post([FromBody] Cart cart)
        {
            if (ModelState.IsValid)
            {
                db.Cart.Add(cart);
                db.SaveChanges();
            }

            return cart;
        }

        // PUT api/cart/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/cart/5
        public void Delete(int id)
        {
            Cart cart = db.Cart.Single(c => c.Id == id);
            db.Cart.Remove(cart);
            db.SaveChanges();
        }
    }
}
