using BookHevan.database;
using BookHevan.Helper;
using BookHevan.Model;
using MySqlConnector;

namespace BookHevan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if username and password is empty
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username and Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Login user
            Form redirect = UserAuth.Login(new User
            {
                username = txtUsername.Text,
                password = txtPassword.Text
            });
            // Redirect to dashboard based on user type
            if (redirect != null)
            {
                redirect.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
