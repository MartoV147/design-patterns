namespace ChatRoomHomeWork
{
    public interface MessageMediator
    {
        void AddUser(User user);

        void SendMessage(string message, User sender);

        public void MarkToKick(User user);
       
    }
}
