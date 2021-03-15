using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class MenuService
    {
        MenuDataAccess menuDataAccess;

        public MenuService()
        {
            this.menuDataAccess = new MenuDataAccess();
        }
        public List<Menu1> GetAllFood()
        {
            return this.menuDataAccess.GetAllFood();
        }
        public int AddFood(string foodname, string price, string status, string categoryName)
        {
            int categoryId = this.menuDataAccess.GetCategoryId(categoryName);
            Menu1 menu = new Menu1()
            {
                FoodName = foodname,
                Price =Convert.ToDouble( price),
                Status = status,
                CategoryId = categoryId
            };
            menuDataAccess = new MenuDataAccess();
            return this.menuDataAccess.InsertFood(menu);
        }
        public int UpdateMenu(int foodId,string foodName, string price, string status, string categoryId)
        {
            Menu1 menu = new Menu1()
            {
                FoodId = foodId,
                FoodName = foodName,
                Price = Convert.ToDouble(price),
                Status = status,
                CategoryId = Convert.ToInt32(categoryId)
            };
            menuDataAccess = new MenuDataAccess();
            return this.menuDataAccess.UpdateFood(menu);
        }
        public int DeleteFood(int catageroyId)
        {
            return this.menuDataAccess.DeleteFood(catageroyId);
        }
        public List<Menu1> GetProductListForSearch(string productName)
        {
            return menuDataAccess.GetFoodForSearch(productName);
        }
    }
}
