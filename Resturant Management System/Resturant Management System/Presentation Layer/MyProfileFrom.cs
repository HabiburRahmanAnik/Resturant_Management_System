using Resturant_Management_System.Data_Access_Layer;
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
    public partial class MyProfileFrom : Form
    {
        WaiterFrom waiterFrom = null;
        AdminFrom adminFrom = null;
        ManagerFrom managerFrom = null;
        string post;
        string name;
        public MyProfileFrom()
        {
            InitializeComponent();
        }
        public MyProfileFrom(AdminFrom adminFrom, string name,string post)
        {
            InitializeComponent();
            this.name = name;
            this.adminFrom = adminFrom;
            this.post = post;
        }
        public MyProfileFrom(WaiterFrom waiterFrom, string name, string post)
        {
            InitializeComponent();
            this.name = name;
            this.waiterFrom=waiterFrom;
            this.post = post;
        }
        public MyProfileFrom(ManagerFrom managerFrom, string name, string post)
        {
            InitializeComponent();
            this.name = name;
            this.managerFrom = managerFrom;
            this.post = post;
        }
        private void MyProfileFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MyProfileFrom_Load(object sender, EventArgs e)
        {
            ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
            dataGridView1.DataSource = manageEmployeeService.GetUser(name);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChangePasswordFrom changePassword = new ChangePasswordFrom(this,name);
            changePassword.Show();
            this.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (adminFrom != null)
            {
                adminFrom.Show();
            }
            else if (managerFrom != null)
            {
                managerFrom.Show();
            }
            else if (waiterFrom != null)
            {
                waiterFrom.Show();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }
    }
}
