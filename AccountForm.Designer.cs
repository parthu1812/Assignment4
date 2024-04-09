namespace Assignment4
{
    partial class AccountForm
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
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            AccountType = new DataGridViewTextBoxColumn();
            CurrentBalance = new DataGridViewTextBoxColumn();
            DateCreated = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(548, 189);
            button2.Name = "button2";
            button2.Size = new Size(204, 29);
            button2.TabIndex = 5;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(548, 131);
            button1.Name = "button1";
            button1.Size = new Size(204, 29);
            button1.TabIndex = 4;
            button1.Text = "View Transaction History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AccountType, CurrentBalance, DateCreated });
            dataGridView1.Location = new Point(48, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 188);
            dataGridView1.TabIndex = 3;
            // 
            // AccountType
            // 
            AccountType.HeaderText = "AccountType";
            AccountType.MinimumWidth = 6;
            AccountType.Name = "AccountType";
            AccountType.Width = 125;
            // 
            // CurrentBalance
            // 
            CurrentBalance.HeaderText = "CurrentBalance";
            CurrentBalance.MinimumWidth = 6;
            CurrentBalance.Name = "CurrentBalance";
            CurrentBalance.Width = 125;
            // 
            // DateCreated
            // 
            DateCreated.HeaderText = "DateCreated";
            DateCreated.MinimumWidth = 6;
            DateCreated.Name = "DateCreated";
            DateCreated.Width = 125;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "AccountForm";
            Text = "AccountForm";
            Load += AccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn CurrentBalance;
        private DataGridViewTextBoxColumn DateCreated;
    }
}