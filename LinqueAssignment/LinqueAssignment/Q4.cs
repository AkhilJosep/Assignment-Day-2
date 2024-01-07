using LinqueAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInQAssignment
{
    //4. For the previous exercise, write a LINQ query that displays the details grouped by the month in the descending order of the order date.
    internal class Q4
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

            var result = from order1 in orderlist
                         orderby order1.OrderDate descending
                         group order1 by order1.OrderDate.Month;


            Console.WriteLine("Recent to Oldest Order...");


            foreach (var order in result)
            {
                Console.WriteLine($"Order of month:{order.Key}");
                foreach (var item in order)
                {
                    Console.WriteLine(item.ItemName);
                }


            }


        }
    }
}
