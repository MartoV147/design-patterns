using System.Collections.Generic;
namespace ChatRoomHomeWork
{
	class Chat : MessageMediator
	{
		private List<User> users;
        private User userToKick;

		public Chat()
		{
			users = new List<User>();
		}

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void MarkToKick(User user) 
        {
            userToKick = user;
        }

        public void SendMessage(string message, User sender)
        {
            if (message.Equals("addBot"))
            {
                ChatBot bot = ChatBot.Instance;
                bot.SetChat(this);
            }

            foreach (User u in users) 
            {
                if (sender != u)
                {
                    u.Recieve(message, sender);
                }
            }

            if (userToKick != null)
            {
                users.Remove(userToKick);
                userToKick = null;
            }
        }


    }
}
