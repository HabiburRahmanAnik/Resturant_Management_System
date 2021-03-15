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
    public partial class PaymentFrom : Form
    {
        AdminFrom adminFrom;
        ManagerFrom managerFrom;
        string foodName,date,post;
        int orderid=0;
        public PaymentFrom()
        {
            InitializeComponent();
        }
        public PaymentFrom(ManagerFrom managerFrom,string post)
        {
            InitializeComponent();
            this.managerFrom = managerFrom;
            this.post = post;
        }
        public PaymentFrom(AdminFrom adminFrom,string post)
        {
            InitializeComponent();
            this.adminFrom = adminFrom;
            this.post = post;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void PaymentFrom_Load(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            payment_dataGridViewOrder.DataSource = orderService.GetAllOrder();
        }

        private void PaymentFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void payment_dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodName = payment_dataGridViewOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            totalTextBox.Text = payment_dataGridViewOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            date = payment_dataGridViewOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            orderid = (int)payment_dataGridViewOrder.Rows[e.RowIndex].Cells[0].Value;
            double total = double.Parse(totalTextBox.Text);
            double vat = total * 0.1;
            vatTextBox.Text = vat.ToString();
            totalPaymentTextBox.Text = (total + vat).ToString();
        }

        private void paid_AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if(paid_AmountTextBox.Text=="")
            {
                return_AmountTextBox.Text = "";
            }
            else
            {
                double totalpayment = Convert.ToDouble(totalPaymentTextBox.Text);
                double paid = Convert.ToDouble(paid_AmountTextBox.Text);
                return_AmountTextBox.Text = (paid - totalpayment).ToString();
            }           
        }

        private void textBoxSearchId_TextChanged(object sender, EventArgs e)
        {
            if(paymentSearchTextBox.Text=="")
            {
                payment_dataGridViewOrder.DataSource = "";
                this.Refresh(this, null);
            }
            else
            {
                OrderService orderService = new OrderService();
                payment_dataGridViewOrder.DataSource = orderService.OrderSearch(paymentSearchTextBox.Text);
            }
            
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            if(totalTextBox.Text==""||vatTextBox.Text==""||paid_AmountTextBox.Text==""||return_AmountTextBox.Text==""||totalPaymentTextBox.Text=="")
            {
                MessageBox.Show("Fill up the required from");
            }
            else
            {
                PaymentService paymentService = new PaymentService();
                int result = paymentService.AddPayment(foodName, totalPaymentTextBox.Text, date);
                if(result>0)
                {
                    OrderService orderService = new OrderService();
                    orderService.DeleteOrder(orderid);
                    MessageBox.Show("Payment  Successfull");
                    this.Refresh(this, null);
                    this.Clear(this, null);
                }
                else
                {
                    MessageBox.Show("Payment can`t successfull");
                }
            }

        }
        void Refresh(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            payment_dataGridViewOrder.DataSource = orderService.GetAllOrder();
        }

        private void vatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        void Clear(object sender, EventArgs e)
        {
            totalTextBox.Text = vatTextBox.Text = paid_AmountTextBox.Text = return_AmountTextBox.Text = totalPaymentTextBox.Text = string.Empty;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(post.Equals("Admin"))
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
