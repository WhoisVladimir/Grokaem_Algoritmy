using System;
using System.Collections.Generic;
using System.Text;

namespace _04_BreadthFirstSearch
{
    class Friend
    {
        public string Name { get; }
        public bool IsSeller { get; }
        public List<Friend> FriendList { get; private set; }
        public Friend(string name, bool isSeller)
        {
            Name = name;
            IsSeller = isSeller;
        }

        public void AddFriends(List<Friend> friends)
        {
            FriendList = friends;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
