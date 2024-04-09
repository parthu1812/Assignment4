using Assignment4.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment4
{
    public partial class TransactionForm : Form
    {
        //get the account id from the account form
        public Account accountId;
        public TransactionForm(Account accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountId == null)
            {
                MessageBox.Show("Account ID is not available.");
                return;
            }
            // Attempt to parse the date, amount, and get the description from the user inputs
            bool isDateParsed = DateTime.TryParse(dateTxt.Text, out DateTime date);
            bool isAmountParsed = decimal.TryParse(amntTxt.Text, out decimal amount);
            string description = descTxt.Text;

            // Check if both date and amount were successfully parsed
            if (!isDateParsed)
            {
                MessageBox.Show("Invalid date format.");
                return; // Exit the method if the date is not valid
            }

            if (!isAmountParsed)
            {
                MessageBox.Show("Invalid amount format.");
                return; // Exit the method if the amount is not valid
            }

            // Proceed to add the transaction to the transaction history
            using (MMABooksContext db = new MMABooksContext())
            {
                if (accountId != null){

                    decimal currentBalance = Convert.ToDecimal(accountId.CurrentBalance);
                if (string.IsNullOrEmpty(amntTxt.Text) || string.IsNullOrEmpty(descTxt.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else if (amount < 0)
                {
                    MessageBox.Show("Amount cannot be negative");
                    return;
                }
                //if amount is greater than current balance
                else if (amount > currentBalance)
                {
                    MessageBox.Show("Amount cannot be greater than current balance");
                    return;
                }
                else
                {
                    // Create a new transaction history object
                    TransactionHistory transaction = new TransactionHistory
                    {
                        AccountId = accountId.AccountId,
                        TransactionDate = date,
                        Amount = amount,
                        Description = description
                    };

                    // Add the transaction to the database
                    db.TransactionHistories.Add(transaction);
                    db.SaveChanges();
                    updateGrid();
                    MessageBox.Show("Transaction Added");
                    dateTxt.Text = "";
                    amntTxt.Text = "";
                    descTxt.Text = "";
                }
                }
                else
                {
                    // Handle the case where accountId is null
                    MessageBox.Show("Account ID is not available.");
                }

            }
            
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            // Ensure accountId is not null before accessing its properties
            if (accountId != null)
            {
                // Use accountId safely
                using (MMABooksContext db = new MMABooksContext())
                {
                    // Check if db.TransactionHistories is not null before using it
                    if (db.TransactionHistories != null)
                    {
                        // Filter TransactionHistories by accountId
                        var transactions = db.TransactionHistories.Where(t => t.AccountId == accountId.AccountId).ToList();

                        // Add transactions to dataGridView1
                        foreach (var transaction in transactions)
                        {
                            dataGridView1.Rows.Add(transaction.TransactionDate, transaction.Amount, transaction.Description);
                        }
                    }
                    else
                    {
                        // Handle the case where TransactionHistories is null
                        MessageBox.Show("Transaction history is not available.");
                    }
                }
            }
            else
            {
                // Handle the case where accountId is null
                MessageBox.Show("Account ID is not available.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dateTxt.Text = row.Cells[0].Value.ToString();
                amntTxt.Text = row.Cells[1].Value.ToString();
                descTxt.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update the transaction history
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (string.IsNullOrEmpty(amntTxt.Text) || string.IsNullOrEmpty(descTxt.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else if (decimal.Parse(amntTxt.Text) < 0)
                {
                    MessageBox.Show("Amount cannot be negative");
                    return;
                }
                else if (decimal.Parse(amntTxt.Text) > Convert.ToDecimal(accountId.CurrentBalance))
                {
                    MessageBox.Show("Amount cannot be greater than current balance");
                    return;
                }
                else
                {
                    using (MMABooksContext db = new MMABooksContext())
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        TransactionHistory transaction = db.TransactionHistories.Where(t => t.AccountId == accountId.AccountId && t.TransactionDate == (DateTime)row.Cells[0].Value).FirstOrDefault();
                        transaction.TransactionDate = DateTime.Parse(dateTxt.Text);
                        transaction.Amount = decimal.Parse(amntTxt.Text);
                        transaction.Description = descTxt.Text;
                        db.SaveChanges();
                        updateGrid();
                        MessageBox.Show("Transaction Updated");
                        dateTxt.Text = "";
                        amntTxt.Text = "";
                        descTxt.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a transaction to update");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete the transaction history
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult = MessageBox.Show("Are you sure you want to delete this transaction?", "Info", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    using (MMABooksContext db = new MMABooksContext())
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        TransactionHistory transaction = db.TransactionHistories.Where(t => t.AccountId == accountId.AccountId && t.TransactionDate == (DateTime)row.Cells[0].Value).FirstOrDefault();
                        db.TransactionHistories.Remove(transaction);
                        db.SaveChanges();
                        updateGrid();
                        MessageBox.Show("Transaction Deleted");
                        dateTxt.Text = "";
                        amntTxt.Text = "";
                        descTxt.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a transaction to delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MMABooksContext db = new MMABooksContext())
            {
                // Fetch the user based on the UserId
                User user = db.Users.Where(u => u.Id == accountId.UserId).FirstOrDefault();

                if (user != null) // Ensure user is not null
                {
                    // Pass the user object to AccountForm
                    AccountForm accountForm = new AccountForm(user);
                    accountForm.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
            }

        }

        private void updateGrid()
        {
            //update the gridbox
            using (MMABooksContext db = new MMABooksContext())
            {
                dataGridView1.Rows.Clear();
                foreach (var transaction in db.TransactionHistories.Where(t => t.AccountId == accountId.AccountId).ToList())
                {
                    dataGridView1.Rows.Add(transaction.TransactionDate, transaction.Amount, transaction.Description);
                }
            }
        }
    }
}
