using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqueAssignment
{
    //5. You have created Order class in the previous exercise and that has order id , item name, order date and quantity .
    //Create another class called Item that has item name and  price. Write a LINQ query such that it returns order id, item name,
    //order date and the total price (price * quantity ) grouped by the month in the descending order of the order date.
    class Item
    {
        public float Price { get; set; }
        public string ItemName { get; set; }
    }

    class Price
    {
        public float Total_Price { get; set; }
        public string Item_Name { get; set; }
        public int Order_ID { get; set; }
        public DateTime Order_Date { get; set; }
    }

    internal class Q5
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

                         select new Price() { Order_ID = order1.OrderId, Item_Name = order1.ItemName, Order_Date = order1.OrderDate, Total_Price = order1.Quantity * item1.Price };


            var resultFinal = from order1 in result
                              orderby order1.Order_Date descending
                              group order1 by order1.Order_Date.Month;



            foreach (var order in resultFinal)
            {
                Console.WriteLine($"Order of month:{order.Key}");
                foreach (var item in order)
                {
                    Console.WriteLine($"ID: {item.Order_ID} Name:{item.Item_Name} Total:{item.Total_Price} Date:{item.Order_Date}");
                }
            }
        }


    }
}