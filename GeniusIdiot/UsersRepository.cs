using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot
{
    [Serializable]
    class UsersRepository
    {
        List<User> users = new List<User>();
        
        public List<User> Items
        {
            get
            {
                return new List<User>(users);
            }
            set { }
        }
        public void Add(User newUser)
        {
            foreach (var user in users)
            {
                if (newUser.Name == user.Name)
                {
                    user.Update(newUser);
                    return;
                }
            }
            users.Add(newUser);
        }


    }
}
