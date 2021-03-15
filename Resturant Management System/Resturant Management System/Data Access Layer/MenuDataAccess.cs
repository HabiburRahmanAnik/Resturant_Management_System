using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System.Data_Access_Layer
{
    class MenuDataAccess
    {
        DataAccess dataAccess;
        public MenuDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Menu1> GetAllFood()
        {
            string query = "SELECT * FROM Menu2";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<Menu1> menus = new List<Menu1>();

            while(reader.Read())
            {
                Menu1 menu = new Menu1();
                menu.FoodId = (int)reader["FoodId"];
                menu.FoodName = reader["FoodName"].ToString();
                menu.Price =Convert.ToDouble( reader["Price"]);
                menu.Status = reader["Status"].ToString();
                menu.CategoryId = (int)reader["CategoryId"];
                menus.Add(menu);
                
            }
            return menus;
        }
        public int InsertFood(Menu1 menu)
        {
            string sql = "INSERT INTO Menu2(FoodName,Price,Status,CategoryId) VALUES('" + menu.FoodName + "','" + menu.Price + "','" + menu.Status + "','" + menu.CategoryId + "')";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public int GetCategoryId(string categoryName)
        {
            string query = "SELECT *FROM Categories WHERE CategoryName='" + categoryName + "'";
            SqlDataReader reader = this.dataAccess.GetData(query);
            reader.Read();
            return (int)reader["CategoryId"];
        }
        public int DeleteFood(int id)
        {
            string query = "DELETE FROM Menu2 WHERE FoodId=" + id;
            return this.dataAccess.ExecuteQuery(query);
        }
        public int UpdateFood(Menu1 menu)
        {
            string query = "UPDATE Menu2 SET [FoodName]='" + menu.FoodName + "',[Price]='" + menu.Price+ "',[Status]='" + menu.Status + "',[CategoryId]='" + menu.CategoryId + "' WHERE [FoodId]=" + menu.FoodId;
            return this.dataAccess.ExecuteQuery(query);
        }
        public List<Menu1> GetFoodForSearch(string foodName)
        {
            string sql = "SELECT * FROM Menu2 WHERE FoodName LIKE '" + foodName + "%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Menu1> menus = new List<Menu1>();
            while (reader.Read())
            {
                Menu1 menu = new Menu1();
                menu.FoodId = (int)reader["FoodId"];
                menu.FoodName = reader["FoodName"].ToString();
                menu.Price = Convert.ToDouble(reader["Price"]);
                menu.Status = reader["Status"].ToString();
                menu.CategoryId = (int)reader["CategoryId"];
                menus.Add(menu);
            }
            return menus;
        }
    }
}
