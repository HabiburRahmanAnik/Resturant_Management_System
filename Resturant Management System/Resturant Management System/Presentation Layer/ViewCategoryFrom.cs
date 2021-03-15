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
    public partial class ViewCategoryFrom : Form
    {
        ManagerFrom managerFrom;
        WaiterFrom waiterFrom;
        string post;
        public ViewCategoryFrom(ManagerFrom managerFrom,string post)
        {
            InitializeComponent();
            this.managerFrom = managerFrom;
            this.post = post;
        }
        public ViewCategoryFrom(WaiterFrom waiterFrom, string post)
        {
            InitializeComponent();
            this.waiterFrom = waiterFrom;
            this.post = post;
        }
        private void ViewCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
           dataGridView1.DataSource = categoryService.GetAllCategories();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(post.Equals("Manager"))
            { 
                managerFrom.Show();
                this.Hide();
            }
            else
            {
                waiterFrom.Show();
                this.Hide();
            }      
        }
    }
}
