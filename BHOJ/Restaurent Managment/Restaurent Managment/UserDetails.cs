using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent_Managment
{
    public class UserDetails
    {
        private string userName;
        private string userRole;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
    }
}
