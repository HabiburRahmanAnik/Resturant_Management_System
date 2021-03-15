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
    public partial class FinancialFrom : Form
    {
        AdminFrom adminFrom;
        ManagerFrom managerFrom;
        string post;

        public FinancialFrom()
        {
            InitializeComponent();
        }
        public FinancialFrom(AdminFrom adminFrom, string post)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
            this.post = post;
        }
        public FinancialFrom(ManagerFrom managerFrom, string post)
        {
            InitializeComponent();
            this.managerFrom = managerFrom;
            this.post = post;
        }

        private void FinancialFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FinancialFrom_Load(object sender, EventArgs e)
        {
            PaymentService paymentService = new PaymentService();
            financialDataGridView.DataSource = paymentService.GetAllList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinancialService financialService = new FinancialService();
            financialDataGridView.DataSource = financialService.GetFinancial(from_dateTimePicker.Text,to_dateTimePicker.Text);
            if (totalSellLabel.Text != "")
            {
                double sum = 0.0;
                for (int i = 0; i <= financialDataGridView.Rows.Count - 1; i++)
                {
                    sum = sum + double.Parse(financialDataGridView.Rows[i].Cells[2].Value.ToString());
                }
                totalSellLabel.Text = "Total Sell Price: ";
                totalSellLabel.Text = "Total Sell Price:  " + sum.ToString();
            }
            else
            {
                totalSellLabel.Text = "";
            }

        }

        private void totalSellLabel_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (post.Equals("Admin"))
            {
                adminFrom.Show();
                this.Hide();
            }
            else
            {
                managerFrom.Show();
                this.Hide();
            }
        }
    }
}
