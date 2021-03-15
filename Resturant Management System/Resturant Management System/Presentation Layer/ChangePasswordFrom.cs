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
    public partial class ChangePasswordFrom : Form
    {
        MyProfileFrom myProfileFrom;
        string name;
        public ChangePasswordFrom()
        {
            InitializeComponent();
        }
        public ChangePasswordFrom(MyProfileFrom myProfileFrom, string name)
        {
            InitializeComponent();
            this.myProfileFrom = myProfileFrom;
            this.name = name;
        }

        private void ChangePasswordFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
          
            if (oldPasswordTextBox.Text == "" || newPasswordTextBox.Text == "" || confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else if(newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("new and confirm password does not match");
            }
            else
            {
               
                ChangePasswordService changePasswordService = new ChangePasswordService();

                if (changePasswordService.GetPassword(this.name).Equals(oldPasswordTextBox.Text))
                {
                    ChangePasswordService changePasswordService1 = new ChangePasswordService();
                    int result = changePasswordService1.ChangePassword(this.name, newPasswordTextBox.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("Password change successfully");
                        oldPasswordTextBox.Text = newPasswordTextBox.Text = confirmPasswordTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Your old password does not match");
                }
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myProfileFrom.Show();
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
