using LinqueAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqueAssignment
{
    //6. Do the previous exercise using anonymous types.
    internal class Q6
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

            List<Item> itemlist = new List<Item>()
            {
                new Item(){ItemName="Book",Price=2800.0f },
                new Item(){ItemName="Ball",Price=5000.0f },
                new Item(){ItemName="Pen",Price=1500.0f },
                new Item(){ItemName="Pencil",Price=1300.0f },
                new Item(){ItemName="Eraser",Price=1000.0f }

            };

            var result = from order1 in orderlist
                         join item1 in itemlist
                         on order1.ItemName equals item1.ItemName

                         select new { id =order1.OrderId, name = order1.ItemName, date = order1.OrderDate, total = order1.Quantity * item1.Price };


            var resultFinal = from order1 in result
                              orderby order1.date descending
                              group order1 by order1.date.Month;



            foreach (var order in resultFinal)
            {
                Console.WriteLine($"Order of month:{order.Key}");
                foreach (var item in order)
                {
                    Console.WriteLine($"ID: {item.id} Name:{item.name} Total:{item.total} Date:{item.date}");
                }
            }
        }
    }
}
