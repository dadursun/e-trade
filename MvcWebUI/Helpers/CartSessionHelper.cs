using Entities.DomainModels;
using Microsoft.AspNetCore.Http;
using MvcWebUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Helpers
{
    public class CartSessionHelper : ICartSessionHelper
    {
        private IHttpContextAccessor _httpContextAccesor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccesor = httpContextAccessor;
        }
        public void Clear()
        {
            _httpContextAccesor.HttpContext.Session.Clear();
        }

        public Cart GetCart(string key)
        {
            Cart cartToCheck = _httpContextAccesor.HttpContext.Session.GetObject<Cart>(key);
            if (cartToCheck==null)
            {
                SetCart(key, new Cart());
                cartToCheck= _httpContextAccesor.HttpContext.Session.GetObject<Cart>(key);
            }
            return cartToCheck;
        }

        public void SetCart(string key,Cart cart)
        {
            _httpContextAccesor.HttpContext.Session.SetObject(key, cart);
        }
    }
}
