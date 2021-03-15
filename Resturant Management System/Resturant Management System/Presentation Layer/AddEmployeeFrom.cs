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
    public partial class AddEmployeeFrom : Form
    {
        AdminFrom adminFrom;
        public AddEmployeeFrom(AdminFrom adminFrom)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string gen = null;
            if (maleRadioButton.Checked)
            {
                gen = maleRadioButton.Text;
            }
            else
            {
                gen = femaleRadioButton.Text;
            }
            string gen1 = null;
            if (marriedRadioButton.Checked)
            {
                gen1 = marriedRadioButton.Text;
            }
            else
            {
                gen1 = unmarriedRadioButton.Text;
            }
            if (nameTextBox.Text == "" || userNameTextBox.Text == "" || salaryTextBox.Text == "" || AddressTextBox.Text == "" || emailTextBox.Text == "" || postComboBox.Text ==""||dateOfBirht_DateTimePicker.Text==""||joiningDateTimePicker.Text=="")
            {
                MessageBox.Show("Fill up the required from");
            }
            else if(passwordtextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password don`t match");
            }
            else
            {
                AddEmployeeService addEmployeeService = new AddEmployeeService();
                int result = addEmployeeService.InsertEmployee(nameTextBox.Text,userNameTextBox.Text,passwordtextBox.Text,emailTextBox.Text,postComboBox.Text,dateOfBirht_DateTimePicker.Text,joiningDateTimePicker.Text,salaryTextBox.Text,bloodGroupComboBox.Text,gen,gen1,AddressTextBox.Text);
                if(result>0)
                {
                    MessageBox.Show("Employee add Successfully");
                    nameTextBox.Text = userNameTextBox.Text = passwordtextBox.Text = confirmPasswordTextBox.Text= emailTextBox.Text = postComboBox.Text = dateOfBirht_DateTimePicker.Text = joiningDateTimePicker.Text = salaryTextBox.Text = bloodGroupComboBox.Text = AddressTextBox.Text = string.Empty;
                    maleRadioButton.Checked = femaleRadioButton.Checked = marriedRadioButton.Checked = unmarriedRadioButton.Checked = false;

                }
                else
                {
                    MessageBox.Show("cant`t add employee");
                }
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminFrom.Show();
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
