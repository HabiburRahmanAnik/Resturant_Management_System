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
    public partial class ViewOrderFrom : Form
    {
        ManagerFrom managerFrom;
        string post;
        public ViewOrderFrom(ManagerFrom managerFrom,string post)
        {
            InitializeComponent();
            this.managerFrom = managerFrom;
            this.post = post;
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            order_DataGridView.DataSource = orderService.GetAllOrder();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerFrom.Show();
            this.Hide();
        }

        private void ViewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
