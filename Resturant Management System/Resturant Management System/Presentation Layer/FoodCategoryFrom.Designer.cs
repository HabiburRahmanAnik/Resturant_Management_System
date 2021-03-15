namespace Resturant_Management_System.Presentation_Layer
{
    partial class FoodCategoryFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryName_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_Category_Button = new System.Windows.Forms.Button();
            this.update_Category_Button = new System.Windows.Forms.Button();
            this.add_CategoryButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.food_Category_DataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_Category_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            // 
            // categoryName_TextBox
            // 
            this.categoryName_TextBox.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName_TextBox.Location = new System.Drawing.Point(170, 89);
            this.categoryName_TextBox.Name = "categoryName_TextBox";
            this.categoryName_TextBox.Size = new System.Drawing.Size(256, 29);
            this.categoryName_TextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_Category_Button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.categoryName_TextBox);
            this.groupBox1.Controls.Add(this.update_Category_Button);
            this.groupBox1.Controls.Add(this.add_CategoryButton);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Category";
            // 
            // delete_Category_Button
            // 
            this.delete_Category_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.delete_Category_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_Category_Button.Location = new System.Drawing.Point(352, 194);
            this.delete_Category_Button.Name = "delete_Category_Button";
            this.delete_Category_Button.Size = new System.Drawing.Size(112, 43);
            this.delete_Category_Button.TabIndex = 0;
            this.delete_Category_Button.Text = "Delete";
            this.delete_Category_Button.UseVisualStyleBackColor = false;
            this.delete_Category_Button.Click += new System.EventHandler(this.delete_Category_Button_Click);
            // 
            // update_Category_Button
            // 
            this.update_Category_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.update_Category_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_Category_Button.Location = new System.Drawing.Point(196, 194);
            this.update_Category_Button.Name = "update_Category_Button";
            this.update_Category_Button.Size = new System.Drawing.Size(114, 43);
            this.update_Category_Button.TabIndex = 0;
            this.update_Category_Button.Text = "Update";
            this.update_Category_Button.UseVisualStyleBackColor = false;
            this.update_Category_Button.Click += new System.EventHandler(this.update_Category_Button_Click);
            // 
            // add_CategoryButton
            // 
            this.add_CategoryButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.add_CategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_CategoryButton.Location = new System.Drawing.Point(25, 194);
            this.add_CategoryButton.Name = "add_CategoryButton";
            this.add_CategoryButton.Size = new System.Drawing.Size(129, 43);
            this.add_CategoryButton.TabIndex = 0;
            this.add_CategoryButton.Text = "Add";
            this.add_CategoryButton.UseVisualStyleBackColor = false;
            this.add_CategoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 28);
            this.menuStrip1.TabIndex = 5;
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // food_Category_DataGridView
            // 
            this.food_Category_DataGridView.AllowUserToAddRows = false;
            this.food_Category_DataGridView.AllowUserToDeleteRows = false;
            this.food_Category_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.food_Category_DataGridView.Location = new System.Drawing.Point(532, 68);
            this.food_Category_DataGridView.Name = "food_Category_DataGridView";
            this.food_Category_DataGridView.ReadOnly = true;
            this.food_Category_DataGridView.RowHeadersWidth = 51;
            this.food_Category_DataGridView.RowTemplate.Height = 24;
            this.food_Category_DataGridView.Size = new System.Drawing.Size(348, 273);
            this.food_Category_DataGridView.TabIndex = 0;
            this.food_Category_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.food_Category_DataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of Category";
            // 
            // FoodCategoryFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.food_Category_DataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FoodCategoryFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodCategory_FormClosing);
            this.Load += new System.EventHandler(this.FoodCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_Category_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryName_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_Category_Button;
        private System.Windows.Forms.Button update_Category_Button;
        private System.Windows.Forms.Button add_CategoryButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView food_Category_DataGridView;
        private System.Windows.Forms.Label label2;
    }
}