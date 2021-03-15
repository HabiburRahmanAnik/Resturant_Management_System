using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class CategoryService
    {
        CategoryDataAccess categoryDataAccess;

        public CategoryService()
        {
            this.categoryDataAccess = new CategoryDataAccess();
        }

        public List<Category> GetAllCategories()
        {
            return this.categoryDataAccess.GetAllCategories();
        }
        public int AddCategory(string categroyName)
        {
            Category catageroy = new Category()
            {
                CategoryName = categroyName
            };
            return this.categoryDataAccess.InsertCategory(catageroy);
        }
        public int DeleteCategory(int id)
        {
            return this.categoryDataAccess.DeleteCategory(id);
        }
        public int UpdateCategory(int categoryId,string categoryName)
        {
            Category category = new Category()
            {
                CategoryId = categoryId,
                CategoryName = categoryName
            };
            return this.categoryDataAccess.UpdateCategory(category);
        }
        public List<string> GetCategoryNameList()
        {
            return this.categoryDataAccess.GetCategoryNames();
        }
        public List<Menu1> GetMenuByCategory(string categoryName)
        {
            return this.categoryDataAccess.GetProductByCategory(categoryName);
        }
        
    }
}
