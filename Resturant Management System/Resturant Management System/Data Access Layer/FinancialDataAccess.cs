using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class FinancialDataAccess
    {
        DataAccess dataAccess;
        public FinancialDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Payment> GetFinancial(string fromDate,string toDate)
        {
            string query = "SELECT * FROM Financilas WHERE Date >= '"+fromDate+"' AND Date <= '"+toDate+"' ORDER BY Date";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<Payment> financilas = new List<Payment>();
            while (reader.Read())
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
    }
}
