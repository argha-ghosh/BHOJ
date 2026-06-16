using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent_Managment
{
    public static class CartManager
    {
        public static List<CartItem> CartItems { get; } = new List<CartItem>();
    }

    public class CartItem
    {
        public string Category { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
    }

}
