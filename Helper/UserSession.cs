using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookHevan.Helper
{
    /* This class is used to store the user session data. 
     * It is used to store the user data after the user has logged in.
     * */
    public static class UserSession
    {
        public static int id { get; private set; }
        public static string username { get; private set; }
        public static string fullName { get; private set; }
        public static string phoneNo { get; private set; }
        public static string type { get; private set; }

        /**
         * This method is used to set the user data after the user has logged in.
         * */
        public static void SetUser(int userId, string username, string fullName, string phoneNo, string userType)
        {
            id = userId;
            username = username;
            fullName = fullName;
            phoneNo = phoneNo;
            type = userType;
        }

        /**
         * This method is used to clear the user data after the user has logged out.
         * */
        public static void Clear()
        {
            id = 0;
            username = fullName = phoneNo = type = string.Empty;
        }
    }
}
