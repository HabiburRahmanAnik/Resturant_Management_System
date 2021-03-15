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
    public partial class AdminFrom : Form
    {
        AddEmployeeFrom addEmployee;
        LoginFrom loginFrom;
        string name;
        string post;
        public AdminFrom()
        {
            InitializeComponent();
        }
        public AdminFrom(LoginFrom loginFrom, string name,string post)
        {
            InitializeComponent();
            welcomelabel.Text +=" " +name;
            this.post = post;
            this.name = name;
            this.loginFrom = loginFrom;
        }

        private void AdminFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployee = new AddEmployeeFrom(this);
            addEmployee.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {           
            MenuFrom menuFrom = new MenuFrom(this,post);
            menuFrom.Show();
            this.Hide();
        }

        private void btnFinancials_Click(object sender, EventArgs e)
        {          
            FinancialFrom financialFrom = new FinancialFrom(this,post);
            financialFrom.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {            
            OrderFrom orderFrom = new OrderFrom(this,post);
            orderFrom.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {           
            PaymentFrom paymentFrom =new PaymentFrom(this,post);
            paymentFrom.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();

        }

        private void food_Category_Button_Click(object sender, EventArgs e)
        {
            FoodCategoryFrom foodCategory = new FoodCategoryFrom(this);
            foodCategory.Show();
            this.Hide();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            BookingTableFrom bookingTableFrom = new BookingTableFrom(this, post);
            bookingTableFrom.Show();
            this.Hide();
        }

        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            ManageEmployeeFrom manageEmployee = new ManageEmployeeFrom(this,post);
            manageEmployee.Show();
            this.Hide();

        }

        private void btnManageManager_Click(object sender, EventArgs e)
        {
            string post = "Manager";
            ManageEmployeeFrom manageEmployee = new ManageEmployeeFrom(this, post);
            manageEmployee.Show();
            this.Hide();
        }

        private void btnManageWaiter_Click(object sender, EventArgs e)
        {
            string post = "Waiter";
            ManageEmployeeFrom manageEmployee = new ManageEmployeeFrom(this, post);
            manageEmployee.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileFrom myProfileFrom = new MyProfileFrom(this,name,post);
            myProfileFrom.Show();
            this.Hide();
        }
    }
}
