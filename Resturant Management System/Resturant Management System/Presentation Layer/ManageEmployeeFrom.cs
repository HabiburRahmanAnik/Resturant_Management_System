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
    public partial class ManageEmployeeFrom : Form
    {
        AdminFrom adminFrom=null;
        ManagerFrom managerFrom=null;
        UpdateEmployeeFrom updateEmployeeFrom;
        string post;
        public ManageEmployeeFrom()
        {
            InitializeComponent();
        }
        public ManageEmployeeFrom(AdminFrom adminFrom, string post)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
            this.post = post;
        }
        public ManageEmployeeFrom(ManagerFrom managerFrom, string post)
        {
            InitializeComponent();
            this.managerFrom=managerFrom;
            this.post = post;
        }
        
        private void ManageEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
            manageEmployee_DataGridView.DataSource = manageEmployeeService.GetAllEmployee(post);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(adminFrom != null)
            {
                adminFrom.Show();
            }
            else if(managerFrom != null)
            {
                managerFrom.Show();
            }

        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployeeFrom deleteEmployee = new DeleteEmployeeFrom(this,post);
            deleteEmployee.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateEmployeeFrom = new UpdateEmployeeFrom(this,post);
            updateEmployeeFrom.Show();
            this.Hide();
        }

        private void manageEmployee_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(searchTextBox.Text=="")
            {
                this.ManageEmployee_Load(this, null);
            }
            else
            {
                ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
                manageEmployee_DataGridView.DataSource = manageEmployeeService.SearchEMployee(searchTextBox.Text);
            }
           
        }
    }
}
