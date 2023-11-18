using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyEnumComposition.Enum;

namespace UdemyEnumComposition.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public void addItems(params OrderItem[] items)
        {
            foreach (OrderItem item in items)
            {
                this.Items.Add(item);
            }
        }

        public void removeItem(OrderItem item) { Items.Remove(item); }

        public double total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.subTotal();
            }
            return total;
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public Order()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(this.Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(this.Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(this.Client.ToString());
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(this.total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
