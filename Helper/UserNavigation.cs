using BookHevan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.Helper
{
    internal class UserNavigation
    {
        public static void navigateToDashboard(Form activeForm)
        {
            if (UserSession.type == "Admin")
            {
                new AdminDashboard().Show();
                activeForm.Hide();
            }
            else if (UserSession.type == "Sales Clerk")
            {
                new StaffDashboard().Show();
                activeForm.Hide();
            }
        }
    }
}
