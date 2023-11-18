

using System.Globalization;
using UdemyEnumComposition.Entities;
using UdemyEnumComposition.Enum;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string clientname = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
string[] birthdate = Console.ReadLine().Split('/');



Console.WriteLine("\nEnter order data:");
Console.Write("Status: ");
OrderStatus status= Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
Console.Write("How many items to this order? ");
int num = int.Parse(Console.ReadLine());
OrderItem[] orderItems = new OrderItem[num];
Product[] products = new Product[num];
for (int i=0; i<num; i++)
{
    Console.WriteLine($"Enter #{i+1} item data");
    Console.Write("Product name: ");
    string productname = Console.ReadLine();
    Console.Write("Product price: ");
    products[i]=new Product(productname, double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
    Console.Write("Quantity: ");
    orderItems[i] = new OrderItem(products[i],int.Parse(Console.ReadLine()), products[i].Price);

}
Console.WriteLine();
Order order = new Order(DateTime.Now,status,new Client(clientname,email,new DateTime(int.Parse(birthdate[2]), int.Parse(birthdate[1]), int.Parse(birthdate[0]))));
order.addItems(orderItems);
Console.WriteLine(order.ToString());