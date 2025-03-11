using BookHevan.Model;
using BookHevan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.Helper
{
    internal class UserAuth
    {
        /**
         * Login user
         * @param user
         * @return Form: AdminDashboard or StaffDashboard based on user type
         */
        public static Form? Login(User user)
        {
            if (user.username != null && user.password != null)
            {
                // Search user by username
                User searchUser = User.searchByUsername(user.username);
                if (searchUser.id != 0 && searchUser.password != null)
                {
                    // Verify password
                    bool isVerify = PasswordSecurity.VerifyPassword(user.username, searchUser.password);
                    if (isVerify)
                    {
                        // Set user session
                        UserSession.SetUser(searchUser.id, searchUser.username, searchUser.fullName, searchUser.phoneNo, searchUser.type);
                        // Redirect to dashboard based on user type
                        if (searchUser.type == "Admin")
                        {
                            return new AdminDashboard();
                        }
                        else if (searchUser.type == "Sales Clerk")
                        {
                            return new StaffDashboard();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("User not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Username or Password Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return null;
        }
    }
}
