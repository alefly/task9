using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public string name { get; set; }
        private List<User> followers { get; set; }

        public User(string name) {
            this.name = name;
            followers = new List<User>();
        }
        public void follow(User user)
        {
            followers.Add(user);
        }

        public void unfollow(User user)
        {
            followers.Remove(user);
        }

        public void hear(string phrase, string nameSender)
        {
            Console.WriteLine($"Пользователь {name} услышал сообщение {phrase} от пользователя {nameSender}");
        }

        public void say(string phrase)
        {
            foreach (var user in followers)
            {
                user.hear(phrase, name);
            }
        }
    }
}
