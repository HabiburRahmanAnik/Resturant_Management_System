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
    public partial class BookingTableFrom : Form
    {
        int id = 0;
        AdminFrom adminFrom;
        ManagerFrom managerFrom;
        DeleteBookingTableFrom dbt;
        string post;
        public BookingTableFrom()
        {
            InitializeComponent();
        }
        //public BookingTableFrom(DeleteBookingTable dbt)
        //{
        //    InitializeComponent();
        //    this.dbt = dbt;
        //}
        public BookingTableFrom(ManagerFrom managerFrom,string post)
        {
            InitializeComponent();
            this.managerFrom = managerFrom;
            this.post = post;
        }
        public BookingTableFrom(AdminFrom adminFrom,string post)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
            this.post = post;
        }

        private void BookingTableFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="" || txtEmail.Text==""||txtContact.Text==""||cmbNoOfGuest.Text==""||cmbTableType.Text==""||arrival_Time_DateTimePicker.Text=="")
            {
                MessageBox.Show("Fill up the requirde From");
            }
            else
            {
                BookingTableService bookingTableService = new BookingTableService();
                int result = bookingTableService.BookTable(txtName.Text,txtEmail.Text,cmbTableType.Text,cmbNoOfGuest.Text,txtContact.Text,arrival_Time_DateTimePicker.Text);
                if(result>0)
                {
                    MessageBox.Show("Table Book successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Table not booked");
                }
            }
        }

        private void BookingTableFrom_Load(object sender, EventArgs e)
        {
            BookingTableService bookingTableService = new BookingTableService();
            bookTable_DataGridView.DataSource = bookingTableService.GetAllTable();
        }
        void Refresh(object sender, EventArgs e)
        {
            BookingTableService bookingTableService = new BookingTableService();
            bookTable_DataGridView.DataSource = bookingTableService.GetAllTable();
        }
        void Clear(object sender, EventArgs e)
        {
            txtName.Text = txtEmail.Text = txtContact.Text = cmbNoOfGuest.Text = cmbTableType.Text = arrival_Time_DateTimePicker.Text = string.Empty;
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (post.Equals("Admin"))
            {
                //adminFrom = new AdminFrom();
                adminFrom.Show();
                this.Hide();
            }
            else
            {
                managerFrom.Show();
                this.Hide();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteBookingTableFrom deleteBookingTable = new DeleteBookingTableFrom(this, post);
            deleteBookingTable.Show();
            this.Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtContact.Text == "" || cmbNoOfGuest.Text == "" || cmbTableType.Text == "" || arrival_Time_DateTimePicker.Text == "")
            {
                MessageBox.Show("Fill up the requirde From");
            }
            else
            {
                BookingTableService bookingTableService = new BookingTableService();
                int result = bookingTableService.UpdateTable(id,txtName.Text, txtEmail.Text, cmbTableType.Text, cmbNoOfGuest.Text, txtContact.Text, arrival_Time_DateTimePicker.Text);
                if (result > 0)
                {
                    MessageBox.Show("Table Book successfully");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Table not booked");
                }
            }
        }

        private void bookTable_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =(int) bookTable_DataGridView.Rows[e.RowIndex].Cells[0].Value;
            txtName.Text = bookTable_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = bookTable_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbTableType.Text = bookTable_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbNoOfGuest.Text = bookTable_DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtContact.Text = bookTable_DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            arrival_Time_DateTimePicker.Text = bookTable_DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
