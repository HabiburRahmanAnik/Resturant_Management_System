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
    public partial class OrderFrom : Form
    {
        int foodId = 0;
        string post;
        AdminFrom adminFrom;
        WaiterFrom waiterFrom;

        public OrderFrom()
        {
            InitializeComponent();
        }
        public OrderFrom(AdminFrom adminFrom,string post)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
            this.post = post;
        }
        public OrderFrom(WaiterFrom waiterFrom, string post)
        {
            InitializeComponent();
            this.waiterFrom = waiterFrom;
            this.post = post;
        }

        private void OrderFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderFrom_Load(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            menu_DataGridView.DataSource = menuService.GetAllFood();
            OrderService orderService = new OrderService();
            order_DataGridView.DataSource = orderService.GetAllOrder();
            CategoryService categoryService = new CategoryService();
            categoryName_ComboBox.DataSource = categoryService.GetCategoryNameList();

        }

        private void menu_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            food_Name_TextBox.Text = menu_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text = menu_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            statusTextBox.Text = menu_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (food_Name_TextBox.Text == "" || priceTextBox.Text == "" || quantity_TextBox.Text == "" || dateTimePicker1.Text == "" || total_Price_TextBox.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else if(statusTextBox.Text== "Unavailable")
            {
                MessageBox.Show("Sorry!! This food is not Available");
            }
            else
            {
                OrderService orderService = new OrderService();
                int result = orderService.AddOrder(food_Name_TextBox.Text, quantity_TextBox.Text, total_Price_TextBox.Text, dateTimePicker1.Text);
                if (result > 0)
                {
                    MessageBox.Show("Order added seccessfully");
                    this.Refresh(this, null);
                    this.ClearMenu(this, null);
                }
                else
                {
                    MessageBox.Show("Order can`t add");
                }
            }
        }
        void Refresh(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            menu_DataGridView.DataSource = menuService.GetAllFood();
            OrderService orderService = new OrderService();
            order_DataGridView.DataSource = orderService.GetAllOrder();
        }
        void ClearMenu(object sender, EventArgs e)
        {
            food_Name_TextBox.Text = priceTextBox.Text = quantity_TextBox.Text = total_Price_TextBox.Text =statusTextBox.Text= string.Empty;
        }
        void ClearOrder(object sender, EventArgs e)
        {
            foodNameTextBox2.Text = total_Amount_TextBox.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (foodNameTextBox2.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else
            {
                OrderService orderService = new OrderService();
                int result = orderService.DeleteOrder(foodId);
                if (result > 0)
                {
                    MessageBox.Show("Order delete successfully");
                    this.Refresh1(this, null);
                    this.ClearOrder(this, null);
                }
                else
                {
                    MessageBox.Show("error occur");
                }
            }
        }

        private void order_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = (int)order_DataGridView.Rows[e.RowIndex].Cells[0].Value;
            foodNameTextBox2.Text = order_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            total_Amount_TextBox.Text = order_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }
        void Refresh1(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            order_DataGridView.DataSource = orderService.GetAllOrder();
        }

        private void quantity_TextBox_TextChanged(object sender, EventArgs e)
        {
            if(quantity_TextBox.Text=="")
            {              
                total_Price_TextBox.Text = "";
            }
            else
            {
                int text = (Convert.ToInt32(priceTextBox.Text)) * (Convert.ToInt32(quantity_TextBox.Text));
                total_Price_TextBox.Text = text.ToString();
            }            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            menu_DataGridView.DataSource = categoryService.GetMenuByCategory(categoryName_ComboBox.Text);
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (post.Equals("Admin"))
            {
                adminFrom.Show();
                this.Hide();
            }
            else
            {
                waiterFrom.Show();
                this.Hide();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void food_Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            quantity_TextBox.Text = total_Price_TextBox.Text = string.Empty;
        }
    }
}
