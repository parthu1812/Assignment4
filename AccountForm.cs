using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4.Models.Entities;

namespace Assignment4
{
    public partial class AccountForm : Form
    {
        //get the user object from the login form
        public User user;
        public AccountForm(User user)
        {
            InitializeComponent();
            this.user = user;

            
        }
            private void AccountForm_Load(object sender, EventArgs e)
        {
            //on form load, display the using userid show the account details
            using (MMABooksContext db = new MMABooksContext())
            {
                Account account = db.Accounts.Where(a => a.UserId == user.Id).FirstOrDefault();
                //show account details in gridbox, show all acoount types of particular userid
                foreach (var accountType in db.Accounts.Where(a => a.UserId == user.Id).ToList())
                {
                    dataGridView1.Rows.Add(accountType.AccountType, accountType.CurrentBalance, accountType.DateCreated);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //acount should be passed to the transaction form
            using (MMABooksContext db = new MMABooksContext())
            {
                Account account = db.Accounts.Where(a => a.UserId == user.Id).FirstOrDefault();
                TransactionForm transactionForm = new TransactionForm(account);
                transactionForm.Show();
                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
