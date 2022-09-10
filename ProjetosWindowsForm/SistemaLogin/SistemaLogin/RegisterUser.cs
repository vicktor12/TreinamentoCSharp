using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static internal class RegisterUser
    {
        private static User[] _users = 
        {
            new User(){ Name = "Victor", Password = "abc123"},
            new User(){ Name = "Lay", Password = "def456"},
            new User(){ Name = "Kleber", Password = "ghi789"},
        };

        private static User _userSession = null;

        public static User UserLogged
        {
            get { return _userSession; }
            private set { _userSession = value; }
        }

        public static bool Login(string name, string pass)
        {   
            
            foreach(User user in _users)
            {
                if(user.Name == name && user.Password == pass)
                {
                    UserLogged = user;
                    return true;
                }
            }
            return false;
        }
    }
}
