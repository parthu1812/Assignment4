using Assignment4.Models.Entities;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        //private Operation op = new Operation();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;

            // Check if email and password are empty
            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password");
                return;
            }
            else
            {
                // Check if the email and password are valid
                using (MMABooksContext db = new MMABooksContext())
                {
                    // Check if the user exists in the database
                    User user = db.Users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
                    if (user != null)
                    {
                        MessageBox.Show("Login Successful");
                        AccountForm accountForm = new AccountForm(user);
                        accountForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
