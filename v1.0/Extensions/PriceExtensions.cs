using System;

namespace HubPedidos.v1.Models
{
    public static class PriceExtensions
    {
        public static long ToLongPrice(this double price)
        {
            return Convert.ToInt64(price * 100);
        }
        
        public static long ToLongPrice(this decimal price)
        {
            return Convert.ToInt64(price * 100);
        }
    }
}