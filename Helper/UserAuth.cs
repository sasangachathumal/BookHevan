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
        public static Form? Login(User user)
        {
            if (user.username != null && user.password != null)
            {
                User searchUser = User.searchByUsername(user.username);
                if (searchUser.id != 0 && searchUser.password != null)
                {
                    bool isVerify = PasswordSecurity.VerifyPassword(user.username, searchUser.password);
                    if (isVerify)
                    {
                        UserSession.SetUser(searchUser.id, searchUser.username, searchUser.fullName, searchUser.phoneNo, searchUser.type);
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
