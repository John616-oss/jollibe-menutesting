namespace jollibe_menu
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            btnLog = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnEmployee = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            label8 = new Label();
            txtQuantity = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtProduct = new TextBox();
            txtID = new TextBox();
            button4 = new Button();
            label7 = new Label();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 67);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(515, 18);
            label2.Name = "label2";
            label2.Size = new Size(217, 32);
            label2.TabIndex = 1;
            label2.Text = "admin dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnLog);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnEmployee);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 474);
            panel2.TabIndex = 1;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.Red;
            btnLog.FlatStyle = FlatStyle.Popup;
            btnLog.ForeColor = SystemColors.ButtonFace;
            btnLog.Location = new Point(21, 355);
            btnLog.Margin = new Padding(3, 2, 3, 2);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(173, 40);
            btnLog.TabIndex = 4;
            btnLog.Text = "LOGOUT";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(126, 24);
            label1.TabIndex = 2;
            label1.Text = "ADMIN USER";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(21, 52);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 95);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Red;
            btnEmployee.FlatStyle = FlatStyle.Popup;
            btnEmployee.ForeColor = SystemColors.ButtonFace;
            btnEmployee.Location = new Point(21, 200);
            btnEmployee.Margin = new Padding(3, 2, 3, 2);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(173, 40);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(224, 194);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(636, 347);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(563, 167);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(196, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(765, 164);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 26);
            button1.TabIndex = 4;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(txtCategory);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(txtProduct);
            panel3.Controls.Add(txtID);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(866, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 474);
            panel3.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(52, 263);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 11;
            label8.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(52, 287);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(195, 23);
            txtQuantity.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 213);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 9;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 155);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 8;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 105);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 7;
            label4.Text = "Products:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 54);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 6;
            label3.Text = "Id:";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(52, 419);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Record";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(52, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(195, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Record";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(52, 237);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(195, 23);
            txtCategory.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(52, 179);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(195, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(52, 129);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(195, 23);
            txtProduct.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(52, 78);
            txtID.Name = "txtID";
            txtID.Size = new Size(195, 23);
            txtID.TabIndex = 0;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(765, 132);
            button4.Name = "button4";
            button4.Size = new Size(95, 27);
            button4.TabIndex = 6;
            button4.Text = "REFRESH";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(224, 157);
            label7.Name = "label7";
            label7.Size = new Size(102, 32);
            label7.TabIndex = 7;
            label7.Text = "STOCKS";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(52, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 35);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add Record";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddRecord_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 541);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnEmployee;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnLog;
        private Button button1;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtProduct;
        private TextBox txtID;
        private Button button4;
        private Label label7;
        private Label label8;
        private TextBox txtQuantity;
        private Button btnAdd;
    }
}