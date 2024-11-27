namespace Сельскохозяйственные_работы
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            CompanyQ = new Button();
            EmployeesQ = new Button();
            ProductsQ = new Button();
            SuppliesQ = new Button();
            Query1 = new Button();
            Query2 = new Button();
            Query3 = new Button();
            Query4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(797, 311);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CompanyQ
            // 
            CompanyQ.BackColor = Color.Transparent;
            CompanyQ.FlatStyle = FlatStyle.Popup;
            CompanyQ.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CompanyQ.ForeColor = Color.Transparent;
            CompanyQ.Location = new Point(591, 359);
            CompanyQ.Name = "CompanyQ";
            CompanyQ.Size = new Size(97, 33);
            CompanyQ.TabIndex = 1;
            CompanyQ.Text = "Кафедра";
            CompanyQ.UseVisualStyleBackColor = false;
            CompanyQ.Click += CompanyQ_Click;
            // 
            // EmployeesQ
            // 
            EmployeesQ.BackColor = Color.Transparent;
            EmployeesQ.FlatStyle = FlatStyle.Popup;
            EmployeesQ.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeesQ.ForeColor = Color.Transparent;
            EmployeesQ.Location = new Point(291, 359);
            EmployeesQ.Name = "EmployeesQ";
            EmployeesQ.Size = new Size(103, 33);
            EmployeesQ.TabIndex = 2;
            EmployeesQ.Text = "Учителя";
            EmployeesQ.UseVisualStyleBackColor = false;
            EmployeesQ.Click += EmployeesQ_Click;
            // 
            // ProductsQ
            // 
            ProductsQ.BackColor = Color.Transparent;
            ProductsQ.FlatStyle = FlatStyle.Popup;
            ProductsQ.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductsQ.ForeColor = Color.Transparent;
            ProductsQ.Location = new Point(725, 359);
            ProductsQ.Name = "ProductsQ";
            ProductsQ.Size = new Size(95, 33);
            ProductsQ.TabIndex = 4;
            ProductsQ.Text = "Аудитории";
            ProductsQ.UseVisualStyleBackColor = false;
            ProductsQ.Click += ProductsQ_Click;
            // 
            // SuppliesQ
            // 
            SuppliesQ.BackColor = Color.Transparent;
            SuppliesQ.FlatStyle = FlatStyle.Popup;
            SuppliesQ.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SuppliesQ.ForeColor = Color.Transparent;
            SuppliesQ.Location = new Point(430, 359);
            SuppliesQ.Name = "SuppliesQ";
            SuppliesQ.Size = new Size(120, 33);
            SuppliesQ.TabIndex = 5;
            SuppliesQ.Text = "Дисциплины";
            SuppliesQ.UseVisualStyleBackColor = false;
            SuppliesQ.Click += SuppliesQ_Click;
            // 
            // Query1
            // 
            Query1.BackColor = Color.Transparent;
            Query1.FlatStyle = FlatStyle.Popup;
            Query1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Query1.ForeColor = Color.Transparent;
            Query1.Location = new Point(336, 464);
            Query1.Name = "Query1";
            Query1.Size = new Size(97, 33);
            Query1.TabIndex = 6;
            Query1.Text = "Запрос 1";
            Query1.UseVisualStyleBackColor = false;
            Query1.Click += Query1_Click;
            // 
            // Query2
            // 
            Query2.BackColor = Color.Transparent;
            Query2.FlatStyle = FlatStyle.Popup;
            Query2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Query2.ForeColor = Color.Transparent;
            Query2.Location = new Point(464, 464);
            Query2.Name = "Query2";
            Query2.Size = new Size(97, 33);
            Query2.TabIndex = 7;
            Query2.Text = "Запрос 2";
            Query2.UseVisualStyleBackColor = false;
            Query2.Click += Query2_Click;
            // 
            // Query3
            // 
            Query3.BackColor = Color.Transparent;
            Query3.FlatStyle = FlatStyle.Popup;
            Query3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Query3.ForeColor = Color.Transparent;
            Query3.Location = new Point(591, 464);
            Query3.Name = "Query3";
            Query3.Size = new Size(97, 33);
            Query3.TabIndex = 8;
            Query3.Text = "Запрос 3";
            Query3.UseVisualStyleBackColor = false;
            Query3.Click += Query3_Click;
            // 
            // Query4
            // 
            Query4.BackColor = Color.Transparent;
            Query4.FlatStyle = FlatStyle.Popup;
            Query4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Query4.ForeColor = Color.Transparent;
            Query4.Location = new Point(723, 464);
            Query4.Name = "Query4";
            Query4.Size = new Size(97, 33);
            Query4.TabIndex = 9;
            Query4.Text = "Запрос 4";
            Query4.UseVisualStyleBackColor = false;
            Query4.Click += Query4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(884, 561);
            Controls.Add(Query4);
            Controls.Add(Query3);
            Controls.Add(Query2);
            Controls.Add(Query1);
            Controls.Add(SuppliesQ);
            Controls.Add(ProductsQ);
            Controls.Add(EmployeesQ);
            Controls.Add(CompanyQ);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button CompanyQ;
        private Button EmployeesQ;
        private Button ProductsQ;
        private Button SuppliesQ;
        private Button Query1;
        private Button Query2;
        private Button Query3;
        private Button Query4;
    }
}
