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
    public partial class ViewMenuFrom : Form
    {
        WaiterFrom waiterFrom;
        string post;
        public ViewMenuFrom(WaiterFrom waiterFrom,string post)
        {
            InitializeComponent();
            this.waiterFrom = waiterFrom;
            this.post = post;
        }

        private void ViewMenuFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewMenuFrom_Load(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            viewMenuDataGridView.DataSource = menuService.GetAllFood();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(searchTextBox.Text=="")
            {
                viewMenuDataGridView.DataSource = "";
                this.ViewMenuFrom_Load(this, null);
            }
            MenuService menuService = new MenuService();
            viewMenuDataGridView.DataSource = menuService.GetProductListForSearch(searchTextBox.Text);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waiterFrom.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }
    }
}
