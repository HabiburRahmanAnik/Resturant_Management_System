using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class OrderDataAccess
    {
        DataAccess dataAccess;
        public OrderDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Order> GetAllOrder()
        {
            string query = "SELECT * FROM Orders";           
            SqlDataReader reader= this.dataAccess.GetData(query);
            List<Order> orders = new List<Order>();

            while(reader.Read())
            {
                Order order = new Order();
                order.Order_Id = (int)reader["Order_Id"];
                order.Food_Name = reader["Food_Name"].ToString();
                order.Quantity = (int)reader["Quantity"];
                order.Total_Amount = (double)reader["Total_Amount"];
                order.Date = reader["Date"].ToString();

                orders.Add(order);
            }
            return orders;
        }

        public int AddOrder(Order order)
        {
            string query = "INSERT INTO Orders (Food_Name,Quantity,Total_Amount,Date) VALUES('"+order.Food_Name+"','"+order.Quantity+"','"+order.Total_Amount+"','"+order.Date+"')";
            return this.dataAccess.ExecuteQuery(query);
        }
        public int DeleteOrder(int id)
        {
            string query = "DELETE FROM Orders WHERE Order_Id=" + id;
            return this.dataAccess.ExecuteQuery(query);
        }
        public int UpdateOrder(Order order)
        {
            string query = "UPDATE Orders SET Food_Name='"+order.Food_Name+"',Quantity='"+order.Quantity+"',Total_Amount='"+order.Total_Amount+"',Date='"+order.Date+"' WHERE Order_Id="+order.Order_Id;
            return this.dataAccess.ExecuteQuery(query);
        }
        public List<Order> OrderSearch(int orderId)
        {
            string query = "SELECT * FROM Orders WHERE [Order_Id] Like '" + orderId + "%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<Order> orders = new List<Order>();

            while (reader.Read())
            {
                Order order = new Order();
                order.Order_Id = (int)reader["Order_Id"];
                order.Food_Name = reader["Food_Name"].ToString();
                order.Quantity = (int)reader["Quantity"];
                order.Total_Amount = (double)reader["Total_Amount"];
                order.Date = reader["Date"].ToString();

                orders.Add(order);
            }
            return orders;

        }
    }
}
