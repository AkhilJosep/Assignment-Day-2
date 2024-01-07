using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqueAssignment
{
    //3. Create an Order class that has order id, item name, order date and quantity. Create a collection of Order objects.
    //Display the data day wise from most recently ordered to least recently ordered and by quantity from highest to lowest.
    public class Order
    {
        public Order(int orderId, string itemName, DateTime orderDate, int quantity)
        {
            OrderId = orderId;
            ItemName = itemName;
            OrderDate = orderDate;
            Quantity = quantity;
        }

        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
    }
    internal class Q3
    {

        public static void Main(string[] args)
        {
            List<Order> orderlist = new List<Order>()
            {
                new Order(101,"Book",new DateTime(2023,4,17),1000),
               new Order (102,"Ball",new DateTime(2023,10,25),100),
               new Order(103,"Pen",new DateTime(2023,8,30),500),
               new Order(104,"Pencil",new DateTime(2023,6,30),450),
               new Order(105,"Eraser",new DateTime(2023,12,30),300)
            };

            var res = from item in orderlist
                         orderby item.OrderDate descending
                         select item;

            Console.WriteLine("Recent to Oldest Order...");


            foreach (var order in res)
            {
                Console.WriteLine($"ID: {order.OrderId} Name:{order.ItemName} Quantity:{order.Quantity} Date:{order.OrderDate}");
            }


            Console.WriteLine("Highest to Lowest Quantity...");

            res = from item in orderlist
                     orderby item.Quantity descending
                     select item;

            foreach (var order in res)
            {
                Console.WriteLine($"ID: {order.OrderId} Name:{order.ItemName} Quantity:{order.Quantity} Date:{order.OrderDate}");
            }
        }


    }
}