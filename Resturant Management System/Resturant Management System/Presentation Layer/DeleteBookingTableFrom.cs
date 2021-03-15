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
    public partial class DeleteBookingTableFrom : Form
    {
        BookingTableFrom bookingTableFrom;
        string post;
        int id = 0;
        public DeleteBookingTableFrom()
        {
            InitializeComponent();
        }
        public DeleteBookingTableFrom(BookingTableFrom bookingTableFrom,string post)
        {
            InitializeComponent();
            this.bookingTableFrom = bookingTableFrom;
            this.post = post;
        }
        private void DeleteBookingTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteBookingTable_Load(object sender, EventArgs e)
        {
            BookingTableService bookingTableService = new BookingTableService();
            deleteDataGridView.DataSource = bookingTableService.GetAllTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(tableIdTextBox.Text=="")
            {
                MessageBox.Show("Please Enter table Id");
            }
            else
            {
                BookingTableService bookingTableService = new BookingTableService();
                int result = bookingTableService.DeleteTable(id);
                if(result>0)
                {
                    MessageBox.Show("Delete table Successfully");
                    tableIdTextBox.Text = "";
                    this.Refreash(this, null);
                }
                else
                {
                    MessageBox.Show("Table not delete");
                }
            }
        }

        private void deleteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =(int) deleteDataGridView.Rows[e.RowIndex].Cells[0].Value;
            tableIdTextBox.Text =Convert.ToString( id);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingTableFrom.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }
        void Refreash(object sender, EventArgs e)
        {
            BookingTableService bookingTableService = new BookingTableService();
            deleteDataGridView.DataSource = bookingTableService.GetAllTable();
        }
    }
}
