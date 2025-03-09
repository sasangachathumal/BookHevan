using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookHevan.Helper
{
    public static class UserSession
    {
        public static int id { get; private set; }
        public static string username { get; private set; }
        public static string fullName { get; private set; }
        public static string phoneNo { get; private set; }

        public static string type { get; private set; }

        public static void SetUser(int userId, string username, string fullName, string phoneNo, string userType)
        {
            id = userId;
            username = username;
            fullName = fullName;
            phoneNo = phoneNo;
            type = userType;
        }

        public static void Clear()
        {
            id = 0;
            username = fullName = phoneNo = type = string.Empty;
        }
    }
}
