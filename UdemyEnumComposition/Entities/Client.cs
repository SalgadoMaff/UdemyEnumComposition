using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEnumComposition.Entities
{
    internal class Client
    {
        public Client()
        {
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append($" ({this.Date.Day}/{this.Date.Month}/{this.Date.Year}) - ");
            sb.Append(this.Email);
            return sb.ToString();
        }
    }
}
