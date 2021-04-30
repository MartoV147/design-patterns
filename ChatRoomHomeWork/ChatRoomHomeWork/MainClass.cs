namespace ChatRoomHomeWork
{
    class MainClass
    {
        static public void Main(string[] args)
        {
            MessageMediator chat = new Chat();

            User user1 = new ChatUser(chat, "Gosho");
            User user2 = new ChatUser(chat, "Stoyan");
            User user3 = new ChatUser(chat, "Kiro");

            user1.Send("nigg");
            user2.Send("ei");
            user1.Send("addBot");
            user3.Send("cat");
            user2.Send("marto");

        }
    }
}
