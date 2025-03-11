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
        /**
         * This method is used to navigate to the dashboard based on the user type
         * @param activeForm
         */
        public static void navigateToDashboard(Form activeForm)
        {
            // Check if the user is an admin
            if (UserSession.type == "Admin")
            {
                new AdminDashboard().Show();
                activeForm.Hide();
            }
            // Check if the user is a sales clerk
            else if (UserSession.type == "Sales Clerk")
            {
                new StaffDashboard().Show();
                activeForm.Hide();
            }
        }
    }
}
