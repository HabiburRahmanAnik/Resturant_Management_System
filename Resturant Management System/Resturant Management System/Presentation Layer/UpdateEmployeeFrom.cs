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
    public partial class UpdateEmployeeFrom : Form
    {
        ManageEmployeeFrom manageEmployeeFrom;
        string post;
        int id = 0;
        public UpdateEmployeeFrom()
        {
            InitializeComponent();
        }
        public UpdateEmployeeFrom(ManageEmployeeFrom manageEmployeeFrom, string post)
        {
            InitializeComponent();
            this.manageEmployeeFrom = manageEmployeeFrom;
            this.post = post;
        }
        private void UpdateEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
            updateEmployee_DataGridView.DataSource = manageEmployeeService.GetAllEmployee(post);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageEmployeeFrom.Show();
            this.Hide();
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
            if (nameTextBox.Text == "" || userNameTextBox.Text == "" || salaryTextBox.Text == "" || AddressTextBox.Text == "" || emailTextBox.Text == "" || postComboBox.Text == "" || dateOfBirht_DateTimePicker.Text == "" || joiningDateTimePicker.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else
            {
                ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
                int result = manageEmployeeService.UpdateEmployee(id, nameTextBox.Text, userNameTextBox.Text, emailTextBox.Text, postComboBox.Text, dateOfBirht_DateTimePicker.Text, joiningDateTimePicker.Text, salaryTextBox.Text, bloodGroupComboBox.Text, gen, gen1, AddressTextBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Employee Update successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("can`t update employee");
                }
            }
        }

        private void updateEmployee_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)updateEmployee_DataGridView.Rows[e.RowIndex].Cells[0].Value;
            nameTextBox.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            userNameTextBox.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailTextBox.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            postComboBox.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateOfBirht_DateTimePicker.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            joiningDateTimePicker.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            salaryTextBox.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            bloodGroupComboBox.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            AddressTextBox.Text = updateEmployee_DataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();


        }
        void Clear(object sender, EventArgs e)
        {
            nameTextBox.Text = userNameTextBox.Text = emailTextBox.Text = postComboBox.Text = dateOfBirht_DateTimePicker.Text = joiningDateTimePicker.Text = salaryTextBox.Text = bloodGroupComboBox.Text = AddressTextBox.Text = string.Empty;
            maleRadioButton.Checked = femaleRadioButton.Checked = marriedRadioButton.Checked = unmarriedRadioButton.Checked = false;
        }
        void Refresh(object sender, EventArgs e)
        {
            ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
            updateEmployee_DataGridView.DataSource = manageEmployeeService.GetAllEmployee(post);
        }
    }
}
