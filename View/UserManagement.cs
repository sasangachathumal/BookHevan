using BookHevan.Helper;
using BookHevan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHevan.View
{
    public partial class UserManagement : Form
    {
        private User selectedUser = new User();
        private bool isUpdating = false;

        public UserManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            viewRest();
        }

        private void viewRest()
        {
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhoneNo.Clear();
            txtUsername.Clear();
            comUserType.SelectedIndex = 0;
            txtPassword.ReadOnly = false;
            btnRegister.Text = "Register";
            checkRest.Visible = false;
            checkRest.Enabled = false;
            isUpdating = false;
            selectedUser = new User();

            dgvUsers.DataSource = User.getUsersForDataTable();
            dgvUsers.ClearSelection();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string password = txtPassword.Text;
            string phoneNo = txtPhoneNo.Text;
            string username = txtUsername.Text;
            string? type = comUserType?.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(fullName) &&
                !string.IsNullOrEmpty(phoneNo) && !string.IsNullOrEmpty(username) &&
                !string.IsNullOrEmpty(type))
            {
                User user = new User();
                user.fullName = fullName;
                user.phoneNo = phoneNo;
                user.username = username;
                user.type = type;

                if (isUpdating)
                {
                    updateUser(user, password);
                }
                else
                {
                    registerUser(user, password);
                }
            }
            else
            {
                MessageBox.Show("Please provide all the required information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registerUser(User user, String password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                user.password = password;
                bool isSuccess = user.create();
                if (isSuccess)
                {
                    MessageBox.Show("User creating is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewRest();
                }
                else
                {
                    MessageBox.Show("User creation fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please provide all the required information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateUser(User user, String password)
        {
            user.id = selectedUser.id;
            if (checkRest.Checked && !string.IsNullOrEmpty(password))
            {
                user.password = password;
            }
            bool isSuccess = user.update();
            if (isSuccess)
            {
                MessageBox.Show("User update is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewRest();
            }
            else
            {
                MessageBox.Show("User update fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                // Get data from specific columns
                selectedUser.id = int.Parse(row.Cells[0].Value.ToString());
                selectedUser.fullName = row.Cells[1].Value.ToString();
                selectedUser.username = row.Cells[2].Value.ToString();
                selectedUser.phoneNo = row.Cells[3].Value.ToString();
                selectedUser.type = row.Cells[4].Value.ToString();

                txtFullName.Text = selectedUser.fullName;
                txtUsername.Text = selectedUser.username;
                txtPhoneNo.Text = selectedUser.phoneNo;
                txtPassword.ReadOnly = true;
                comUserType.SelectedItem = selectedUser.type;
                btnRegister.Text = "Update";
                checkRest.Visible = true;
                checkRest.Enabled = true;
                isUpdating = true;
            }
        }

        private void checkRest_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                MessageBox.Show("Please select user to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedUser.id == UserSession.id)
            {
                MessageBox.Show("Can not delete login user from the system", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete User " +
                selectedUser.fullName + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                bool isSuccess = selectedUser.delete();
                if (isSuccess)
                {
                    MessageBox.Show("User successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User delete fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                viewRest();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchUsers();
        }

        private void searchUsers()
        {
            string searchWord = txtSearchWord.Text;

            if (string.IsNullOrEmpty(searchWord))
            {
                dgvUsers.DataSource = User.getUsersForDataTable();
                dgvUsers.ClearSelection();
                return;
            }

            dgvUsers.DataSource = User.searchByUsernameForDataTable(searchWord);
            dgvUsers.ClearSelection();

        }

        private void txtSearchWord_KeyDown(object sender, KeyEventArgs e)
        {
            searchUsers();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }
    }
}
