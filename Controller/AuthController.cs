using BookHevan.Helper;
using BookHevan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.Controller
{
    internal class AuthController
    {
        public void login(User user)
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
                            // @TODO navigate to Admin dashboard
                        }
                        else if (searchUser.type == "Sales Clerk")
                        {
                            // @TODO navigate to Staff dashboard
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("User not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username or Password Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
