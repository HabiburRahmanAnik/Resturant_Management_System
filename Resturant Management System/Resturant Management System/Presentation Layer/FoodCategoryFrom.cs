using Resturant_Management_System.Resturant_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System.Presentation_Layer
{
    public partial class FoodCategoryFrom : Form
    {
        int id = 0;
        AdminFrom adminFrom;
        public FoodCategoryFrom(AdminFrom adminFrom)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
        }

        private void FoodCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(categoryName_TextBox.Text == "")
            {
                MessageBox.Show("Plese give the Category name");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.AddCategory(categoryName_TextBox.Text);
                if(result>0)
                {
                    MessageBox.Show("Added successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
           
        }

        private void FoodCategory_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            food_Category_DataGridView.DataSource = categoryService.GetAllCategories();
        }

        private void update_Category_Button_Click(object sender, EventArgs e)
        {
            if (categoryName_TextBox.Text == "")
            {
                MessageBox.Show("Fill up the required From");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.UpdateCategory(id,categoryName_TextBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Update successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
        }


        private void delete_Category_Button_Click(object sender, EventArgs e)
        {
            if (categoryName_TextBox.Text == "")
            {
                MessageBox.Show("Fill up the required From");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.DeleteCategory(id);
                if (result > 0)
                {
                    MessageBox.Show("Delete successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
        }
        void Refresh(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            food_Category_DataGridView.DataSource = categoryService.GetAllCategories();
        }
        void Clear(object sender, EventArgs e)
        {
            categoryName_TextBox.Text = string.Empty;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminFrom.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void food_Category_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)food_Category_DataGridView.Rows[e.RowIndex].Cells[0].Value;
            categoryName_TextBox.Text = food_Category_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
