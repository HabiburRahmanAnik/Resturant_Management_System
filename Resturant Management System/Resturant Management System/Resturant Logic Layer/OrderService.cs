using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class OrderService
    {
        OrderDataAccess orderDataAccess;
        public OrderService()
        {
            this.orderDataAccess = new OrderDataAccess();
        }
        public List<Order> GetAllOrder()
        {
            return this.orderDataAccess.GetAllOrder();
        }
        public int AddOrder(string foodName,string quantity,string totalAmmount,string date)
        {
            Order order = new Order()
            {
                Food_Name = foodName,
                Quantity = Convert.ToInt32(quantity),
                Total_Amount = Convert.ToDouble(totalAmmount),
                Date = date
            };
            orderDataAccess = new OrderDataAccess();
            return this.orderDataAccess.AddOrder(order);
        }
        public int DeleteOrder(int id)
        {
            return this.orderDataAccess.DeleteOrder(id);
        }
        public int UpdateOrder(int id,string foodName, string quantity, string totalAmmount, string date)
        {
            Order order = new Order()
            {
                Order_Id = id,
                Food_Name = foodName,
                Quantity = Convert.ToInt32(quantity),
                Total_Amount = Convert.ToDouble(totalAmmount),
                Date = date
            };
            orderDataAccess = new OrderDataAccess();
            return this.orderDataAccess.UpdateOrder(order);
        }
        public List<Order> OrderSearch(string orderId)
        {
            int orderId1 = Convert.ToInt32(orderId);
            return this.orderDataAccess.OrderSearch(orderId1);
        }
    }
}
