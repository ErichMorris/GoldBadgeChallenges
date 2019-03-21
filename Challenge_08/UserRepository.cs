using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_08
{
    public class UserRepository
    {
        private List<User> _userList;
        public UserRepository()
        {
            _userList = new List<User>();
        }
        public void AddUserToList(User newUser)
        {
            _userList.Add(newUser);
        }
        public List <User> GetUserList()
        {
            return _userList;
        }
        
    }
}
