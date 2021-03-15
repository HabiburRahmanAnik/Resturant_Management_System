namespace Resturant_Management_System.Presentation_Layer
{
    partial class PaymentFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalPaymentTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.payment_dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.paymentSearchTextBox = new System.Windows.Forms.TextBox();
            this.buttonSearchId = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.return_AmountTextBox = new System.Windows.Forms.TextBox();
            this.paid_AmountTextBox = new System.Windows.Forms.TextBox();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.labelReturnAmount = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelTotalpayment = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.payment_dataGridViewOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalPaymentTextBox
            // 
            this.totalPaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaymentTextBox.Location = new System.Drawing.Point(228, 191);
            this.totalPaymentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalPaymentTextBox.Name = "totalPaymentTextBox";
            this.totalPaymentTextBox.Size = new System.Drawing.Size(184, 24);
            this.totalPaymentTextBox.TabIndex = 4;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(228, 94);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(184, 24);
            this.totalTextBox.TabIndex = 2;
            // 
            // payment_dataGridViewOrder
            // 
            this.payment_dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_dataGridViewOrder.Location = new System.Drawing.Point(477, 97);
            this.payment_dataGridViewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payment_dataGridViewOrder.Name = "payment_dataGridViewOrder";
            this.payment_dataGridViewOrder.RowHeadersWidth = 51;
            this.payment_dataGridViewOrder.RowTemplate.Height = 24;
            this.payment_dataGridViewOrder.Size = new System.Drawing.Size(607, 328);
            this.payment_dataGridViewOrder.TabIndex = 60;
            this.payment_dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payment_dataGridViewOrder_CellClick);
            // 
            // paymentSearchTextBox
            // 
            this.paymentSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentSearchTextBox.Location = new System.Drawing.Point(477, 67);
            this.paymentSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.paymentSearchTextBox.Name = "paymentSearchTextBox";
            this.paymentSearchTextBox.Size = new System.Drawing.Size(515, 24);
            this.paymentSearchTextBox.TabIndex = 5;
            this.paymentSearchTextBox.TextChanged += new System.EventHandler(this.textBoxSearchId_TextChanged);
            // 
            // buttonSearchId
            // 
            this.buttonSearchId.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchId.Location = new System.Drawing.Point(532, 23);
            this.buttonSearchId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchId.Name = "buttonSearchId";
            this.buttonSearchId.Size = new System.Drawing.Size(85, 25);
            this.buttonSearchId.TabIndex = 58;
            this.buttonSearchId.Text = "Search";
            this.buttonSearchId.UseVisualStyleBackColor = true;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.Location = new System.Drawing.Point(224, 360);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(188, 43);
            this.buttonPayment.TabIndex = 56;
            this.buttonPayment.Text = "Payment";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // return_AmountTextBox
            // 
            this.return_AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_AmountTextBox.Location = new System.Drawing.Point(228, 297);
            this.return_AmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.return_AmountTextBox.Name = "return_AmountTextBox";
            this.return_AmountTextBox.Size = new System.Drawing.Size(184, 24);
            this.return_AmountTextBox.TabIndex = 1;
            // 
            // paid_AmountTextBox
            // 
            this.paid_AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_AmountTextBox.Location = new System.Drawing.Point(228, 247);
            this.paid_AmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.paid_AmountTextBox.Name = "paid_AmountTextBox";
            this.paid_AmountTextBox.Size = new System.Drawing.Size(184, 24);
            this.paid_AmountTextBox.TabIndex = 0;
            this.paid_AmountTextBox.TextChanged += new System.EventHandler(this.paid_AmountTextBox_TextChanged);
            // 
            // vatTextBox
            // 
            this.vatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatTextBox.Location = new System.Drawing.Point(228, 140);
            this.vatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(184, 24);
            this.vatTextBox.TabIndex = 3;
            this.vatTextBox.TextChanged += new System.EventHandler(this.vatTextBox_TextChanged);
            // 
            // labelReturnAmount
            // 
            this.labelReturnAmount.AutoSize = true;
            this.labelReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnAmount.Location = new System.Drawing.Point(62, 300);
            this.labelReturnAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReturnAmount.Name = "labelReturnAmount";
            this.labelReturnAmount.Size = new System.Drawing.Size(107, 18);
            this.labelReturnAmount.TabIndex = 52;
            this.labelReturnAmount.Text = "Return Amount";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaidAmount.Location = new System.Drawing.Point(62, 253);
            this.labelPaidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(92, 18);
            this.labelPaidAmount.TabIndex = 51;
            this.labelPaidAmount.Text = "Paid Amount";
            // 
            // labelTotalpayment
            // 
            this.labelTotalpayment.AutoSize = true;
            this.labelTotalpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalpayment.Location = new System.Drawing.Point(62, 197);
            this.labelTotalpayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalpayment.Name = "labelTotalpayment";
            this.labelTotalpayment.Size = new System.Drawing.Size(103, 18);
            this.labelTotalpayment.TabIndex = 50;
            this.labelTotalpayment.Text = "Total Payment";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVat.Location = new System.Drawing.Point(73, 146);
            this.labelVat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(62, 18);
            this.labelVat.TabIndex = 49;
            this.labelVat.Text = "Vat 10%";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(73, 97);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(96, 18);
            this.labelTotal.TabIndex = 48;
            this.labelTotal.Text = "Total Amount";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 402);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearchId);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(467, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 402);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of order";
            // 
            // PaymentFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 457);
            this.Controls.Add(this.totalPaymentTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.payment_dataGridViewOrder);
            this.Controls.Add(this.paymentSearchTextBox);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.return_AmountTextBox);
            this.Controls.Add(this.paid_AmountTextBox);
            this.Controls.Add(this.vatTextBox);
            this.Controls.Add(this.labelReturnAmount);
            this.Controls.Add(this.labelPaidAmount);
            this.Controls.Add(this.labelTotalpayment);
            this.Controls.Add(this.labelVat);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaymentFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment From";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentFrom_FormClosing);
            this.Load += new System.EventHandler(this.PaymentFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment_dataGridViewOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalPaymentTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridView payment_dataGridViewOrder;
        private System.Windows.Forms.TextBox paymentSearchTextBox;
        private System.Windows.Forms.Button buttonSearchId;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox return_AmountTextBox;
        private System.Windows.Forms.TextBox paid_AmountTextBox;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.Label labelReturnAmount;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Label labelTotalpayment;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}