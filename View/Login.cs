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
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username and Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form redirect = UserAuth.Login(new User
            {
                username = txtUsername.Text,
                password = txtPassword.Text
            });
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
