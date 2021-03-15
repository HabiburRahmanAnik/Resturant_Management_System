using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class PaymentDataAccess
    {
        DataAccess dataAccess;
        public PaymentDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public int AddPayment(Payment paymnet)
        {
            string query = "INSERT INTO Financilas (Food_name,Total_Amount,Date) VALUES('" + paymnet.FoodName + "','" + paymnet.TotalAmount + "','" + paymnet.Date + "')";
            return this.dataAccess.ExecuteQuery(query);
        }

        public List<Payment> GetAllList()
        {
            string query = "SELECT * FROM Financilas";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<Payment> financilas = new List<Payment>();
            while(reader.Read())
            {
                Payment payment = new Payment();
                payment.Id = (int)reader["Id"];
                payment.FoodName = reader["Food_Name"].ToString();
                payment.TotalAmount = (double)reader["Total_Amount"];
                payment.Date = reader["Date"].ToString();
                financilas.Add(payment);
            }
            return financilas;
        }
        public List<Payment> SearchPayment(string foodName)
        {
            string query = "SELECT * FROM Financilas WHERE foodName LIKE '" + foodName + "%'";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<Payment> searchs = new List<Payment>();
            while (reader.Read())
            {
                Payment payment = new Payment();
                payment.Id = (int)reader["Id"];
                payment.FoodName = reader["Food_Name"].ToString();
                payment.TotalAmount = (double)reader["Total_Amount"];
                payment.Date = reader["Date"].ToString();
                searchs.Add(payment);
            }
            return searchs;
        }
    }
}
