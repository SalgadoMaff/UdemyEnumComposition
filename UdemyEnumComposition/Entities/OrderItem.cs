using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEnumComposition.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem(Product product,int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double subTotal()
        {
            return this.Quantity * this.Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append('$');
            sb.Append(Price.ToString("F2",CultureInfo.InvariantCulture));
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(this.subTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
