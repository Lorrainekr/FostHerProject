using ProjetFostHer.Helpers;

using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProjetFostHer
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cartId = SessionHelper.GetObjectFromJson<int>(HttpContext.Session, "cartId");
            Models.Cart cart;
            if (cartId != 0)
            {
                 cart = new Dal().GetCart(cartId);
                using (Dal ctx = new Dal())
                {
                    ctx.BuyEvents(cart);
                    
                    return View(cart);
                }
                }
            else
            {
                 cart = new Models.Cart() { Items = new List<Item>()};
            }
            return View(cart);
        }
        
        public IActionResult Buy(int id)
        {
            var cartId = SessionHelper.GetObjectFromJson<int>(HttpContext.Session, "cartId");
            Dal dal = new Dal();
            if (HttpContext.User.Identity.Name == null) { return View("Error"); }
            int a = Int32.Parse(HttpContext.User.Identity.Name);
            User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();


            if (cartId == 0)
            {
                // cart does not exist so we create it before adding item with product inside
                cartId = dal.CreateCart();
                dal.AddItem(cartId, new Item { ProductId = id, Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cartId", cartId);
            }
            else
            {
                // cart exist then we just add item on it
                Cart cart = dal.GetCart(cartId);
                int res = ProductExistInCart(cart, id);
                if (res != -1)
                {
                    dal.UpdateItemQuantity(res);
                }
                else
                {
                    dal.AddItem(cartId, new Item { ProductId = id, Quantity = 1 });
                }
            }
            return RedirectToAction("Index","Cart");
        }

        public IActionResult Remove(int id)
        {
            var cartId = SessionHelper.GetObjectFromJson<int>(HttpContext.Session, "cartId");
            new Dal().RemoveItem(cartId,id);
            return RedirectToAction("Index");
        }

        // return item.id if product is already in item 
        // return -1 otherwise
        private int ProductExistInCart(Cart cart, int productId)
        {
            foreach (var item in cart.Items)
            {
                if (item.ProductId == productId)
                {
                    return item.Id;
                }
            }
            return -1;
        }
       
       


        

    }
}
