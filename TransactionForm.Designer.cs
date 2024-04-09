namespace Assignment4
{
    partial class TransactionForm
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            descTxt = new TextBox();
            amntTxt = new TextBox();
            dateTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(663, 331);
            button4.Name = "button4";
            button4.Size = new Size(107, 29);
            button4.TabIndex = 21;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(503, 331);
            button3.Name = "button3";
            button3.Size = new Size(115, 29);
            button3.TabIndex = 20;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(663, 271);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 19;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(503, 271);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // descTxt
            // 
            descTxt.Location = new Point(611, 200);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(159, 27);
            descTxt.TabIndex = 17;
            // 
            // amntTxt
            // 
            amntTxt.Location = new Point(612, 148);
            amntTxt.Name = "amntTxt";
            amntTxt.Size = new Size(158, 27);
            amntTxt.TabIndex = 16;
            // 
            // dateTxt
            // 
            dateTxt.Location = new Point(612, 98);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(158, 27);
            dateTxt.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 207);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 14;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 155);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 13;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 101);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 12;
            label1.Text = "Date";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Amount, Description });
            dataGridView1.Location = new Point(31, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 188);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(descTxt);
            Controls.Add(amntTxt);
            Controls.Add(dateTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "TransactionForm";
            Text = "TransactionForm";
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox descTxt;
        private TextBox amntTxt;
        private TextBox dateTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Description;
    }
}