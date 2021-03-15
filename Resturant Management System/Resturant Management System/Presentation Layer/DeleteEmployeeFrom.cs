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
    public partial class DeleteEmployeeFrom : Form
    {
        ManageEmployeeFrom manageEmployee;
        string post;
        int id = 0;
        public DeleteEmployeeFrom()
        {
            InitializeComponent();
        }
        public DeleteEmployeeFrom(ManageEmployeeFrom manageEmployee,string post)
        {
            InitializeComponent();
            this.manageEmployee = manageEmployee;
            this.post = post;
        }
        private void DeleteEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
            delete_Employee_DataGridView.DataSource = manageEmployeeService.GetAllEmployee(post);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageEmployee.Show();
            this.Hide();
        }

        private void delete_Employee_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)delete_Employee_DataGridView.Rows[e.RowIndex].Cells[0].Value;
            usernameTextBox.Text = delete_Employee_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text=="")
            {
                MessageBox.Show("Please enter Username");
            }
            else
            {
                ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
                int result = manageEmployeeService.DeleteEmployee(id);
                if(result>0)
                {
                    MessageBox.Show("Delete successfully");
                    this.Refresh(this, null);
                    usernameTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Can`t delete Employee");
                }
            }
        }
        void Refresh(object sender, EventArgs e)
        {
            ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
            delete_Employee_DataGridView.DataSource = manageEmployeeService.GetAllEmployee(post);
        }
    }
}
