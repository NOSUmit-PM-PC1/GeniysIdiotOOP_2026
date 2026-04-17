using System;
using System.Collections.Generic;

namespace GeniusIdiot
{
    [Serializable]
    public class UsersRepository
    {
        List<User> users = new List<User>();
        
        public List<User> Items
        {
            get
            {
                return new List<User>(users);
            }
            set 
            {
                foreach (var user in value)
                    users.Add(user);               
            }
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

        public override string ToString()
        {
            string result = "";
            foreach(var user in Items) 
                result += user.ToString() + "\n";
            return result;
        }
    }
}
