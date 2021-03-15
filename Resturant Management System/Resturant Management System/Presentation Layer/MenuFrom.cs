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
    public partial class MenuFrom : Form
    {
        ManagerFrom mf;
        WaiterFrom wf;
        AdminFrom adminFrom;
        string post;
        int foodId = 0;
        public MenuFrom(AdminFrom adminFrom, string post)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
            this.post = post;
        }
        public MenuFrom(ManagerFrom mf,string post)
        {
            InitializeComponent();
            this.mf = mf;
            this.post = post;
        }
        public MenuFrom(WaiterFrom wf,string post)
        {
            InitializeComponent();
            this.wf = wf;
            this.post = post;
        }

        private void MenuFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void MenuFrom_Load(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            food_ListDataGridView.DataSource = menuService.GetAllFood();
            CategoryService categoryService = new CategoryService();
            categoryName_ComboBox.DataSource = categoryService.GetCategoryNameList();
        }

        private void food_ListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = (int)food_ListDataGridView.Rows[e.RowIndex].Cells[0].Value;
            foodNameTextBox.Text= food_ListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text= food_ListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            statusTextBox.Text= food_ListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            categoryName_ComboBox.Text = food_ListDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(foodNameTextBox.Text =="" || priceTextBox.Text=="" || statusTextBox.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else
            {
                MenuService menuService = new MenuService();
                int result = menuService.AddFood(foodNameTextBox.Text,priceTextBox.Text,statusTextBox.Text, categoryName_ComboBox.Text);
                if(result>0)
                {
                    MessageBox.Show("Added Successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (foodNameTextBox.Text == "" || priceTextBox.Text == "" || statusTextBox.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else
            {
                MenuService menuService = new MenuService();
                int result = menuService.DeleteFood(foodId);
                if (result > 0)
                {
                    MessageBox.Show("Delete Successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (foodNameTextBox.Text == "" || priceTextBox.Text == "" || statusTextBox.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else
            {
                MenuService menuService = new MenuService();
                int result = menuService.UpdateMenu(foodId ,foodNameTextBox.Text, priceTextBox.Text, statusTextBox.Text, categoryName_ComboBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Update Successfully");
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
            MenuService menuService = new MenuService();
            food_ListDataGridView.DataSource = menuService.GetAllFood();
        }
        void Clear(object sender, EventArgs e)
        {
            foodNameTextBox.Text = priceTextBox.Text = statusTextBox.Text = string.Empty;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           MenuService menuService = new MenuService();
           food_ListDataGridView.DataSource = menuService.GetProductListForSearch(searchTextBox.Text);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(post.Equals("Manager"))
            {
                mf.Show();
                this.Hide();
            }
            else
            {
                adminFrom.Show();
                this.Hide();
            }

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
