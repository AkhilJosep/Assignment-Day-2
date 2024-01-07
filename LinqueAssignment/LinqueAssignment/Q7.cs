using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqueAssignment;

namespace LinqueAssignment
{
    // 7. Check if all the quantities in the Order collection is >0.
    internal class Q7
    {
        static void Main(string[] args)
        {
            /*7.Check if all the quantities in the Order collection is > 0. 
            Get the name of the item that was ordered in largest quantity in a single order. (Hint: use LINQ methods to sort) 
            Find if there are any orders placed before Jan of this year.*/

            List<Order> list = new List<Order>()
            {
               new Order(101,"Book",new DateTime(2023,4,17),1000),
               new Order (102,"Ball",new DateTime(2023,10,25),100),
               new Order(103,"Pen",new DateTime(2023,8,30),500),
               new Order(104,"Pencil",new DateTime(2023,6,30),450),
               new Order(105,"Eraser",new DateTime(2023,12,30),300)
            };


            var res = list.Where(o => o.Quantity > 0);

            if (res != null)
            {
                Console.WriteLine("All the quantities in the Order collection is > 0");
            }
            Console.WriteLine();

            var result1 = list.OrderByDescending(o => o.Quantity).First();
            Console.WriteLine("Item with the largest quantity in a single order:" + result1.ItemName);
            Console.WriteLine();
            var ordersBeforeThisYear = list.Where(o => o.OrderDate < new DateTime(DateTime.Now.Year, 1, 1));
            Console.WriteLine($"Orders placed before January of this year:");
            foreach (var order in ordersBeforeThisYear)
            {
                Console.WriteLine($"OrderID: {order.OrderId}, ItemName: {order.ItemName}, Date: {order.OrderDate.ToShortDateString()}, Qty: {order.Quantity}");
            }

        }
    }
}
